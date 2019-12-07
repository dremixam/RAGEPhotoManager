using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{
    class ProfileManager
    {
        private static List<Profile> _Profiles = new List<Profile>();

        internal static List<Profile> Profiles { get => _Profiles; }

        public static void Scan()
        {
            Profiles.Clear();

            String rockstarPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Rockstar Games";

            if (Directory.Exists(rockstarPath + "\\Red Dead Redemption 2\\Profiles"))
            {
                Model.Debugger.Log("RDR3 found");
                foreach (string dir in Directory.GetDirectories(rockstarPath + "\\Red Dead Redemption 2\\Profiles"))
                {
                    Model.Debugger.Log("RDR3 profile found : " + dir);
                    Profile profile = new Profile(GameType.RDR3, dir);
                    profile.Watch();
                    profile.Load();
                    Profiles.Add(profile);
                }
            }

            if (Directory.Exists(rockstarPath + "\\GTA V\\Profiles"))
            {
                Model.Debugger.Log("GTA5 found");
                foreach (string dir in Directory.GetDirectories(rockstarPath + "\\GTA V\\Profiles"))
                {
                    Model.Debugger.Log("GTA5 profile found : " + dir);
                    Profile profile = new Profile(GameType.GTA5, dir);
                    profile.Watch();
                    profile.Load();
                    Profiles.Add(profile);
                }
            }
        }

        public static void KillAllThreads()
        {
            foreach(Profile profile in Profiles)
            {
                profile.KillWatcherThread();
            }
        }


    }
}
