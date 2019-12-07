using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{
    public class Profile
    {
        private List<Photo> _Photos;
        private GameType _GameType;
        private String _Path;
        private Thread _WatcherThread;

        public GameType GameType { get => _GameType; }
        public string Path { get => _Path; }

        public Profile(GameType gameType, string path)
        {
            _GameType = gameType;
            _Path = path;
            _Photos = new List<Photo>();
        }
        public String Name
        {
            get
            {
                return System.IO.Path.GetFileName(_Path);
            }
        }

        public void Load()
        {
            foreach (string imageFullpath in Directory.GetFiles(_Path, "P" + _GameType.ToString() + "*"))
            {
                LoadPhoto(imageFullpath);
            }
        }

        public void LoadPhoto(String imageFullpath)
        {
            Photo photo = Photo.Load(imageFullpath, _GameType, this);
            foreach (Photo storedPhoto in _Photos)
            {
                if (photo.Equals(storedPhoto))
                {
                    // Photo is already in album, do nothing.
                    return;
                }
            }
            _Photos.Add(photo);
        }

        public void DeletePhoto(Photo photo)
        {
            photo.Delete();
            _Photos.Remove(photo);
        }

        public void Watch()
        {
            FileWatcher fw = new FileWatcher(Path, GameType, this);
            _WatcherThread = new Thread(fw.Run);
            _WatcherThread.Start();
        }

        internal void KillWatcherThread()
        {
            _WatcherThread.Abort();
        }

    }
}
