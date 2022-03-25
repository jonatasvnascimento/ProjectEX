using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ProjectEX
{
    internal class Excel
    {
        public string path = "";
        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        Workbook wb;
        Worksheet ws;
        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }
        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i,j].value2 != null)
            {
                return Convert.ToString(ws.Cells[i, j].value2);
            }
            else
            {
                return "";
            }
        }
        public void WriteToCell(int i, int j, string s)
        {
            i++;
            j++;
            ws.Cells[i, j].value2 = s;
        }
        public void Save()
        {
            wb.Save();
        }
        public void Close()
        {
            wb.Close();
        }
        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }
    }
}
