using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace es_close
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] MyProcess = Process.GetProcessesByName("emulationstation");
            if (MyProcess.Length > 0)
                MyProcess[0].Kill(); //關閉執行中的程式
            Application.Exit();
        }
    }
}
