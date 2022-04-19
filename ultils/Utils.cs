using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static void Movefile(string newPath2, string path)
        {
            var PathImpotacao = System.IO.Path.GetDirectoryName(newPath2);

            string NameFileImportacao = Path.GetFileName(newPath2);
            string NameFileBase = Path.GetFileName(path);

            var NameFile = NameFileBase.Replace(".xlsx", "");

            Directory.CreateDirectory(@$"{PathImpotacao}\{NameFile}");

            var newDirectory = @$"{PathImpotacao}\{NameFile}\{NameFileImportacao}";
            var newDirectory2 = @$"{PathImpotacao}\{NameFile}\{NameFileBase}";

            if (File.Exists(newDirectory))
            {
                File.Delete(newDirectory);
            }
            if (File.Exists(newDirectory2))
            {
                File.Delete(newDirectory2);
            }
            try
            {
                File.Move(newPath2, newDirectory);
                File.Move(path, newDirectory2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            //Process.Start("explorer.exe", $"{newDirectory}");
        }
    }
   
}
