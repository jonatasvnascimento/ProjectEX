using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEX
{
    static class Utils
    {
        public static void CloseExcelCMD()
        {
            Process[] prs = Process.GetProcesses();
            foreach (Process pr in prs)
            {
                if (pr.ProcessName == "EXCEL")
                {
                    pr.Kill();
                }
            }
        }
    }
   
}
