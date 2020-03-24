using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace es_bluetooth
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL Bthprops.cpl");
            Application.Exit();
        }
    }
}
