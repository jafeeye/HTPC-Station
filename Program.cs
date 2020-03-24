using System;
using System.Collections.Generic;
using System.Diagnostics; // 使用Process.Start 需引用 System.Diagnostics
using System.Windows.Forms;

namespace es_launcher
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] MyProcess = Process.GetProcessesByName("emulationstation"); //尋找現在執行名稱 emulationstation 的程式
            if (MyProcess.Length > 0) //執行程式數量大於0，也就是 mulationstation 程式啟動時
                Application.Exit(); //關閉es_launcher程式
            else
                System.Diagnostics.Process.Start(Application.StartupPath + "\\emulationstation.exe"); // ""使用雙引號括弧起來，即將雙引號裡面內容變成字串意思，因為C#不支援單個斜線\打法，所以路徑要改成\\雙斜線，打路徑雙斜線方向可任意
                Application.Exit(); //關閉es_launcher程式
        }
    }
}
