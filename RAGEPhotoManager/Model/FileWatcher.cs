using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{


    class FileWatcher
    {
        private string _Path;
        private GameType _Type;
        private Profile _Profile;
        public string Path { get => _Path; set => _Path = value; }
        internal GameType Type { get => _Type; set => _Type = value; }

        public FileWatcher(string path, GameType type, Profile profile)
        {
            _Path = path;
            _Type = type;
            _Profile = profile;
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public void Run()
        {
            // Create a new FileSystemWatcher and set its properties.
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                Debugger.Log("Watching " + Path);
                watcher.Path = Path;

                // Watch for changes in LastAccess and LastWrite times, and
                // the renaming of files or directories.
                watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;


                Debugger.Log("Watching for \\P" + Type.ToString() + "*");
                watcher.Filter = "P" + Type.ToString() + "*";

                watcher.Changed += OnChanged;
                //watcher.Created += OnChanged;
                //watcher.Deleted += OnChanged;
                //watcher.Renamed += OnChanged;

                watcher.EnableRaisingEvents = true;
                
                while (true)
                {
                    Thread.Sleep(1000);
                }
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Changed && !IsFileLocked(e.FullPath))
            {
                Debugger.Log($"File: {e.FullPath} fichier écrit");
                _Profile.LoadPhoto(e.FullPath);
            }
        }

        const int ERROR_SHARING_VIOLATION = 32;
        const int ERROR_LOCK_VIOLATION = 33;
        private bool IsFileLocked(string file)
        {
            //check that problem is not in destination file
            if (File.Exists(file) == true)
            {
                FileStream stream = null;
                try
                {
                    stream = File.Open(file, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                }
                catch (Exception ex2)
                {
                    //_log.WriteLog(ex2, "Error in checking whether file is locked " + file);
                    int errorCode = Marshal.GetHRForException(ex2) & ((1 << 16) - 1);
                    if ((ex2 is IOException) && (errorCode == ERROR_SHARING_VIOLATION || errorCode == ERROR_LOCK_VIOLATION))
                    {
                        return true;
                    }
                }
                finally
                {
                    if (stream != null)
                        stream.Close();
                }
            }
            return false;
        }




    }
}
