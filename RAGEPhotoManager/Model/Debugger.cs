using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{
    class Debugger
    {

        private static MainWindow _MainWindow = null;

        public static MainWindow MainWindow { get => _MainWindow; set => _MainWindow = value; }

        public static void Log(string str)
        {
#if DEBUG
            MainWindow.Invoke(MainWindow.AddLogEntryDelegate, new Object[] { "[" + DateTime.Now + "] " + str + "\r\n" });
#endif
        }
    }
}
