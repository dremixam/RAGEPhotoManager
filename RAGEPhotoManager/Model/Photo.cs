using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{
    public class Photo
    {
        private static List<Photo> _LoadedPhotos = new List<Photo>();

        private string _Path;
        private Profile _Profile;
        private Bitmap _Thumb;
        private String _Title;
        private String _Description;
        private Metadata _Meta;
        private DateTime _CreationRealTime;

        private int _JPEGOffset;
        private int _JPEGLength;

        public string Title { get => _Title; }
        public Bitmap Thumb { get => _Thumb; }
        public GameType GameType { get => _Profile.GameType;}
        public Metadata Meta { get => _Meta; }
        public DateTime CreationRealTime { get => _CreationRealTime; }
        public string Path { get => _Path; }
        public Profile Profile { get => _Profile; }
        public DateTime IngameDate
        {
            get
            {
                return new DateTime(Meta.time.year, Meta.time.month, Meta.time.day, Meta.time.hour, Meta.time.minute, Meta.time.second);
            }
        }
        public DateTime RealDate
        {
            get
            {
                return Tool.UnixTimeToDateTime(Meta.creat);
            }
        }

        public static Photo Load(string path, GameType gameType, Profile profile)
        {
            Photo newPhoto = new Photo(path, gameType, profile);
            foreach (Photo photo in _LoadedPhotos)
            {
                if (photo.Path == path && photo.GameType == gameType && photo.Profile == profile)
                {
                    if (DateTime.Compare(photo.RealDate, newPhoto.RealDate) >= 0)
                    {
                        // Photo already exists
                        return photo;
                    }
                    else
                    {
                        // y'a un truc a faire ici mais je sais plus quoi
                        break;
                    }
                }
            }

            // photo is a new image 

            if (Settings.SaveToMyPictures) newPhoto.SaveToMyPictures();

            MainWindow.Instance.Invoke(MainWindow.Instance.AddImageEntryDelegate, new Object[] { newPhoto });
            return newPhoto;
        }

        public Photo(string path, GameType gameType, Profile profile)
        {
            _Path = path;
            _Profile = profile;
            _CreationRealTime = File.GetCreationTime(Path);

            using (BinaryReader reader = new BinaryReader(File.Open(Path, FileMode.Open)))
            {
                // Documentation : https://wiki.liberty-tree.net/en/photos

                // Check magic number
                int magicNumber = reader.ReadInt32();
                if (magicNumber != 0x01000000 && magicNumber != 0x04000000)
                {
                    throw new IncorrectRockstarImageFormatException("Invalid magic number" + magicNumber.ToString("X8"));
                }

                // Skip 276 bytes of useless data
                reader.BaseStream.Position += 276;

                if (magicNumber == 0x04000000)
                {
                    // RDR3 has two more int32, just skip them too
                    reader.BaseStream.Position += 8;
                }

                // 4 bytes JPEG
                if (ReadStringFromBinaryReader(reader, 4) != "JPEG")
                {
                    throw new IncorrectRockstarImageFormatException("Invalid JPEG tag");
                }

                // Buffer and image size
                int bufferSize = reader.ReadInt32();
                int imageSize = reader.ReadInt32();

                _JPEGOffset = Convert.ToInt32(reader.BaseStream.Position);
                _JPEGLength = imageSize;

                // Image reading
                Byte[] imageBytes = reader.ReadBytes(imageSize);

                // create thumb et al
                CreateCachedThumb(imageBytes);

                // Keep going to the end of the buffer
                reader.BaseStream.Position += bufferSize - imageSize;

                // 4 bytes JSON
                if (ReadStringFromBinaryReader(reader, 4) != "JSON")
                {
                    throw new IncorrectRockstarImageFormatException("Invalid JSON tag");
                }

                // JSON data
                int jsonLength = reader.ReadInt32();
                String json = ReadStringFromBinaryReader(reader, jsonLength);
                if (magicNumber == 0x04000000)
                {
                    _Meta = Newtonsoft.Json.JsonConvert.DeserializeObject<MetadataRDR3>(json);
                }
                else
                {
                    _Meta = Newtonsoft.Json.JsonConvert.DeserializeObject<MetadataGTAV>(json);
                }

                // 4 bytes TITL
                if (ReadStringFromBinaryReader(reader, 4) != "TITL")
                {
                    throw new IncorrectRockstarImageFormatException("Invalid TITL tag");
                }

                // Title
                int titleLength = reader.ReadInt32();
                _Title = ReadStringFromBinaryReader(reader, titleLength);

                // 4 bytes DESC
                if (ReadStringFromBinaryReader(reader, 4) != "DESC")
                {
                    throw new IncorrectRockstarImageFormatException("Invalid DESC tag");
                }

                // Description
                int descriptionLength = reader.ReadInt32();
                _Description = ReadStringFromBinaryReader(reader, descriptionLength);

                // 4 bytes JEND
                if (ReadStringFromBinaryReader(reader, 4) != "JEND")
                {
                    throw new IncorrectRockstarImageFormatException("Invalid JEND tag");
                }
            }
        }

        private String ReadStringFromBinaryReader(BinaryReader reader, int length)
        {
            Byte[] bytes = reader.ReadBytes(length);
            for (int i = 0; i < length; i++)
            {
                if (bytes[i] == '\0')
                {
                    length = i;
                    break;
                }
            }
            return Encoding.UTF8.GetString(bytes, 0, length);
        }

        private void SaveToMyPictures()
        {
            if (!Directory.Exists(MyPicturesFileName()))
            {
                Stream stream = new FileStream(MyPicturesFileName(), FileMode.Create);
                SaveImageToFile(stream);
                stream.Close();
            }
        }

        public void SaveImageToFile(Stream outputStream)
        {
            using (Stream input = File.OpenRead(_Path))
            {
                byte[] buffer = new byte[_JPEGLength];
                input.Position = _JPEGOffset;
                if (input.Read(buffer, 0, _JPEGLength) != _JPEGLength) throw new Exception("Can't read source file");
                outputStream.Write(buffer, 0, _JPEGLength);
            }
        }

        private string MyPicturesFileName()
        {
            string filePath = Settings.MyPicturesPath + "\\" + GameType.DisplayName() + "\\" + Profile.Name;
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            return filePath + "\\" + Meta.time.ToString() + " - " + Title + "_" + Meta.uid + ".jpg";
        }

        private void CreateCachedThumb(Byte[] imageBytes)
        {
            if (!DataStore.IsThumbCached(System.IO.Path.GetFileName(Path), GameType, Profile))
            {
                using (Image image = Image.FromStream(new MemoryStream(imageBytes)))
                {
                    _Thumb = ImageHelper.ResizeImage(image, 200);
                    DataStore.StorePhotoToCache(System.IO.Path.GetFileName(Path), GameType, Profile, Thumb);
                }
            }
            else
            {
                _Thumb = DataStore.RetrievePhotoFromCache(System.IO.Path.GetFileName(Path), GameType, Profile);
            }
        }

        internal void Delete()
        {
            DataStore.RemovePhotoFromCache(System.IO.Path.GetFileName(Path), GameType, Profile);
            File.Delete(_Path);
            _LoadedPhotos.Remove(this);
        }
    }
    public class IncorrectRockstarImageFormatException : Exception
    {
        public IncorrectRockstarImageFormatException()
        {
        }

        public IncorrectRockstarImageFormatException(string message) : base(message)
        {
        }

        public IncorrectRockstarImageFormatException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
