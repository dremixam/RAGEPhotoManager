using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAGEPhotoManager.Model
{
    static class Settings
    {
        private static bool _SaveToMyPictures;
        private static String _MyPicturesPath;

        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = "RAGE Photo Manager";

        public static bool SaveToMyPictures { get => _SaveToMyPictures; set => _SaveToMyPictures = value; }
        public static string MyPicturesPath
        {
            get => _MyPicturesPath;
            set
            {
                if (value == "")
                {
                    _MyPicturesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\RAGE Photo Manager";
                }
                else
                {
                    _MyPicturesPath = value;
                }
                if (!Directory.Exists(_MyPicturesPath))
                {
                    Directory.CreateDirectory(_MyPicturesPath);
                }
            }
        }

        public static bool LaunchAtStartup
        {
            get
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);

                if (Properties.Settings.Default.launchAtStartup)
                {
                    if (key.OpenSubKey(StartupValue) == null)
                    {
                        key.SetValue(StartupValue, Application.ExecutablePath.ToString());
                    }
                    return true;
                }
                else return false;
            }
            set
            {
#if !DEBUG
                Properties.Settings.Default.launchAtStartup = value;
                RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
                if (value) key.SetValue(StartupValue, Application.ExecutablePath.ToString());
                else key.DeleteValue(StartupValue);
#endif
            }
        }

        public static void Load()
        {
            SaveToMyPictures = Properties.Settings.Default.saveToMyPictures;
            MyPicturesPath = Properties.Settings.Default.saveDir;
        }

        public static void Save()
        {
            Properties.Settings.Default.saveToMyPictures = SaveToMyPictures;
            Properties.Settings.Default.saveDir = MyPicturesPath;
            Properties.Settings.Default.Save();
        }
    }
}
