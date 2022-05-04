using OfficeOpenXml;
using ProjectEX.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEX.ultils
{
    public static class NewExcel
    {
        private static string valueField(object text) => isValid(text) ? text.ToString() : Convert.ToString(text);
        private static bool isValid(object value) => value != null && value.GetType() == typeof(string);
        public static List<CamposExcelModel> LoadValues(string path)
        {
            List<CamposExcelModel> objretorno = new List<CamposExcelModel>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                var sheet = excelPackage.Workbook.Worksheets[0];
                bool continuar = true;
                //var tasks = new List<Task>();
                for (var row = 1; row <= sheet.Dimension.Rows; row++)
                {
                    //var task = Task.Run(async () =>
                    //{
                    //    if (!string.IsNullOrEmpty(sheet.Cells[row + 1, 2].Text))
                    //    {
                            CamposExcelModel campos = new CamposExcelModel();

                            campos.Barra = valueField(sheet.Cells[row + 1, 2].Text).validaCampo(10);
                            campos.NovoProduto = valueField(sheet.Cells[row + 1, 3].Text).validaCampo(15);
                            campos.ItemCTR = valueField(sheet.Cells[row + 1, 4].Text).validaCampo(2);
                            campos.Enxoval = valueField(sheet.Cells[row + 1, 5].Text).validaCampo(15);
                            campos.Descricao = valueField(sheet.Cells[row + 1, 6].Text).validaCampo(60);
                            campos.Cor = valueField(sheet.Cells[row + 1, 7].Text).validaCampo(4);
                            campos.Tamanho = valueField(sheet.Cells[row + 1, 8].Text).validaCampo(2);
                            campos.QtdHigienizações = valueField(sheet.Cells[row + 1, 9].Text).validaCampo(8);
                            campos.Cadastro = valueField(sheet.Cells[row + 1, 10].Text).validaCampo(10, true);
                            campos.Funcionario = valueField(sheet.Cells[row + 1, 11].Text).validaCampo(6);
                            campos.Nome = valueField(sheet.Cells[row + 1, 12].Text).validaCampo(100);
                            campos.NumArm = valueField(sheet.Cells[row + 1, 13].Text).validaCampo(6, false, true);
                            campos.NumGav = valueField(sheet.Cells[row + 1, 14].Text).validaCampo(6);
                            campos.Localização = valueField(sheet.Cells[row + 1, 15].Text).validaCampo(20);
                            campos.CodSet = valueField(sheet.Cells[row + 1, 16].Text).validaCampo(6);
                            campos.DescSetor = valueField(sheet.Cells[row + 1, 17].Text).validaCampo(20);
                            campos.Filial = valueField(sheet.Cells[row + 1, 18].Text).validaCampo(2);
                            campos.NovoContrato = valueField(sheet.Cells[row + 1, 19].Text).validaCampo(6);
                            campos.Contrato = valueField(sheet.Cells[row + 1, 20].Text).validaCampo(50);

                            objretorno.Add(campos);
                    //    }
                    //});

                    //tasks.Add(task);
                }
                //Task.WaitAll(tasks.ToArray());
            }
            return objretorno;
        }
        public static string validaCampo(this string campo, int tamanho, bool date = false, bool armario = false)
        {
            if (isValid(campo))
            {
                if (campo.Length > tamanho)
                {
                    campo = campo.Substring(campo.Length - tamanho);
                }
            }

            if (armario)
            {
                if (campo == "" || campo == "0")
                {
                    campo = "000000";
                }
            }

            if (isValid(campo))
            {
                if (date)
                {
                    if (campo != "")
                    {
                        try
                        {
                            campo = $"{campo.Substring(6, 4)}{campo.Substring(3, 2)}{campo.Substring(0, 2)}";
                        }
                        catch (Exception)
                        {
                        }
                    }

                }
            }
            return campo;
        }
       
    }
}
