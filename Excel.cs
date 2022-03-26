using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public string path { get; set; }
        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        public Workbook wb;
        public Worksheet ws;
        public Excel(string path, int sheet)
        {
            try
            {
                this.path = path;
                wb = excel.Workbooks.Open(path);
                ws = wb.Worksheets[sheet];
            }
            catch (Exception)
            {

                MessageBox.Show("Selecione uma planilha");
            }

        }

        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].value2 != null)
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
        public void CreateNewFile()
        {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this.ws = wb.Worksheets[1];
        }
        public void CreateNewSheet()
        {
            Worksheet worksheet = wb.Worksheets.Add(After: ws);
        }
        public void SelectWorksheet(int SheetNumber)
        {
            this.ws = wb.Worksheets[SheetNumber];
        }
        public void DeleteWorksheet(int SheetNumber)
        {
            wb.Worksheets[SheetNumber].Delete();
        }
        //public void ProtectSheet()
        //{
        //    wb.Protect();
        //}
        //public void ProtectSheet(string password)
        //{
        //    wb.Protect(password);
        //}
        //public void UnprotectSheet(string password)
        //{
        //    wb.Unprotect(password);
        //}
        public int LastRowTotal(_Excel.Worksheet wks)
        {
            _Excel.Range lastCell = wks.Cells.SpecialCells(_Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            return lastCell.Row;
        }
        public object[,] RangeLine(string TableName)
        {
            var lr = LastRowTotal(ws);

            _Excel.Application xl = new _Excel.Application();
            var wb = xl.Workbooks.Open(path);
            ws = (Worksheet)wb.Worksheets[$"{TableName}"];

            object[,] holder = ws.Range[$"A1:AV{lr}"].Value;
            wb.Close(true);

            return holder;

        }
        public void WriteRange(string value)
        {
            _Excel.Range cellRange = ws.Range["A1:A100"];
            cellRange.Value = value;
            wb.Save();
            wb.Close();
            Utils.CloseExcelCMD();
        }
        public string[,] ReadRange(int startI, int startY, int endI, int endY)
        {
            _Excel.Range range = ws.Range[ws.Cells[startI, startY], ws.Cells[endI, endY]];
            object[,] holder = range.Value2;
            string[,] returnstring = new string[endI - startI, endY - startY];

            for (int p = 1; p <= endI - startI; p++)
            {
                for (int q = 1; q <= endY - startY; q++)
                {
                    returnstring[p - 1, q - 1] = holder[p, q].ToString();
                }
            }
            excel.Application.Quit();
            return returnstring;
        }

    }
}
