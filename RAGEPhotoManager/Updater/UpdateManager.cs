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
                string currentVersion = typeof(MainWindow).Assembly.GetName().Version.ToString();
                client.Headers.Add(HttpRequestHeader.UserAgent, "RAGE Photo Manager updater " + currentVersion);
                Stream stream = client.OpenRead("https://github.com/dremixam/RAGEPhotoManager/releases/latest/download/version.txt");
                StreamReader reader = new StreamReader(stream);
                string newestVersion = reader.ReadToEnd().Trim();
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
            process.StartInfo.Arguments = " /i \"" + Path.GetTempPath() + "\\RAGE_Photo_Manager_Installer.msi\" /passive /qb+";
            process.Start();
            process.WaitForExit();
        }
    }
}
