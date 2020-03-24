using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace pegasus_fe_launcher
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Process[] MyProcess = Process.GetProcessesByName("pegasus-fe");
            var startInfo = new ProcessStartInfo();// 宣告startInfo 為一個新的變數
            if (MyProcess.Length > 0)
                Application.Exit(); //關閉執行中的程式
            else
                Environment.SetEnvironmentVariable("PEGASUS_HOME", "C:\\HTPC-SS\\EmulationStation\\");// 設定環境變數，等同CMD set環境變數功能，第一個屬性為還境變數名稱，第二個屬性為環境變數路徑
                startInfo.FileName = Application.StartupPath + "\\pegasus-fe.exe";// 啟動 pegasus-fe
                startInfo.UseShellExecute = true;
                startInfo.Arguments = "--portable"; //多個參數用空白隔開， ""包起來亦為字串
                System.Diagnostics.Process.Start(startInfo);
        }
    }
}
