using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{
    class DataStore
    {

        public static string UserConfigFolder
        {
            get
            {
                string strUserConfigFolder;
                strUserConfigFolder = Path.GetDirectoryName(UserConfigPath);
                if (!Directory.Exists(strUserConfigFolder))
                    Directory.CreateDirectory(strUserConfigFolder);
                return strUserConfigFolder;
            }
        }
        public static string UserConfigPath
        {
            get
            {
                System.Diagnostics.FileVersionInfo versionInfo;
                string strUserConfigPath, strUserConfigFolder;

                strUserConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData, Environment.SpecialFolderOption.Create);
                versionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
                strUserConfigPath = Path.Combine(strUserConfigPath, versionInfo.CompanyName, versionInfo.ProductName, versionInfo.ProductVersion, "user.config");
                strUserConfigFolder = Path.GetDirectoryName(strUserConfigPath);
                if (!Directory.Exists(strUserConfigFolder))
                    Directory.CreateDirectory(strUserConfigFolder);
                return strUserConfigPath;
            }
        }

        public static void Init()
        {
            if (!Directory.Exists(UserConfigFolder + "\\Cache"))
                Directory.CreateDirectory(UserConfigFolder + "\\Cache");
        }

        private static String CachedPictureFilename(String name, GameType gameType, Profile profile)
        {
            return UserConfigFolder + "\\Cache\\" + gameType.ToString() + "_" + profile.Name + "_" + name + ".jpg";
        }

        public static bool IsThumbCached(String name, GameType gameType, Profile profile)
        {
            return Directory.Exists(CachedPictureFilename(name, gameType, profile));
        }

        public static void StorePhotoToCache(String name, GameType gameType, Profile profile, Bitmap resizedImage)
        {
            resizedImage.Save(CachedPictureFilename(name, gameType, profile), ImageFormat.Jpeg);
        }

        public static Bitmap RetrievePhotoFromCache(String name, GameType gameType, Profile profile)
        {
            return (Bitmap)Bitmap.FromFile(CachedPictureFilename(name, gameType, profile));
        }


        public static void RemovePhotoFromCache(String name, GameType gameType, Profile profile)
        {
            File.Delete(CachedPictureFilename(name, gameType, profile));
        }

    }
}
