﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RAGEPhotoManager.Updater
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                string currentVersion = typeof(MainWindow).Assembly.GetName().Version.ToString();
                wc.Headers.Add(HttpRequestHeader.UserAgent, "RAGE Photo Manager updater " + currentVersion);

                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;

                Uri uri = new System.Uri("https://github.com/dremixam/RAGEPhotoManager/releases/latest/download/RAGE_Photo_Manager_Installer.msi");
                String path = Path.GetTempPath() + "RAGE_Photo_Manager_Installer.msi";

                Debug.WriteLine(path);

                wc.DownloadFileAsync(uri, path);
            }
        }


        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.Close();
        }

    }
}
