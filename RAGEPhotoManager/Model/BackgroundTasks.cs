using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{
    class BackgroundTasks
    {
        public static void Run()
        {
            DataStore.Init();
            ProfileManager.Scan();
        }
    }
}
