using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RAGEPhotoManager.Updater
{
    public static class UpdateManager
    {
        public static bool Update()
        {
#if DEBUG
            return false;
#else
            if (CheckUpdate())
            {
                string titleBar = "Update RAGE Photo Manager";
                string message = "An update is available. Apply ?";
                if (MessageBox.Show(message, titleBar, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DownloadUpdate();
                    return true;
                }
            }
            return false;
#endif
        }

        private static bool CheckUpdate()
        {
            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("https://files.liberty-tree.net/version.txt");
                StreamReader reader = new StreamReader(stream);
                string newestVersion = reader.ReadToEnd().Trim();
                string currentVersion = typeof(MainWindow).Assembly.GetName().Version.ToString();
                return newestVersion != currentVersion;
            }
            catch (WebException)
            {
                // Fail silently
                return false;
            }

        }

        private static void DownloadUpdate()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Updater updater = new Updater();
            Application.Run(updater);
            DoUpdate();
        }

        private static void DoUpdate()
        {
            Process process = new Process();
            process.StartInfo.FileName = "msiexec";
            process.StartInfo.Arguments = " /i \"" + Path.GetTempPath() + "\\RAGE_Photo_Manager_Installer.msi\"";
            process.StartInfo.Verb = "runas";
            process.Start();
            process.WaitForExit();
        }
    }
}
