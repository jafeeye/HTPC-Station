using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace es_retroarch
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] MyProcess = Process.GetProcessesByName("retroarch");
            if (MyProcess.Length > 0)
                Application.Exit(); //關閉執行中的程式
            else
                System.Diagnostics.Process.Start(Application.StartupPath + "\\..\\..\\.\\systems\\retroarch\\retroarch.exe"); // Application,StartupPath 在後面要先加上\\雙斜線，之後再打路徑才能辨識
                Application.Exit();
        }
    }
}
