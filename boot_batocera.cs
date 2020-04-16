using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace boot_batocera
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c C:\\Windows\\System32\\cmd.exe";
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;
                startInfo.Verb = "RunAs";
            Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();
                process.StandardInput.WriteLine("bcdedit /bootsequence {4a820782-35aa-11e1-b8e6-80978f9fdf9a} {current} {bootmgr} "); '一定要在最後面加上bootmgr
                process.StandardInput.WriteLine("exit");
                process.WaitForExit();
        }
    }
}
