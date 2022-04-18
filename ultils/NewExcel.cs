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
                var row = 1;
                bool continuar = true;
                while (continuar)
                {
                    if (!String.IsNullOrEmpty(sheet.Cells[row, 2].Text))
                    {
                        CamposExcelModel campos = new CamposExcelModel();

                        campos.Barra = valueField(sheet.Cells[row, 2].Text).validaCampo(10);
                        campos.NovoProduto = valueField(sheet.Cells[row, 3].Text).validaCampo(15);
                        campos.ItemCTR = valueField(sheet.Cells[row, 4].Text).validaCampo(2);
                        campos.Enxoval = valueField(sheet.Cells[row, 5].Text).validaCampo(15);
                        campos.Descricao = valueField(sheet.Cells[row, 6].Text).validaCampo(60);
                        campos.Cor = valueField(sheet.Cells[row, 7].Text).validaCampo(4);
                        campos.Tamanho = valueField(sheet.Cells[row, 8].Text).validaCampo(2);
                        campos.QtdHigienizações = valueField(sheet.Cells[row, 9].Text).validaCampo(8);
                        campos.Cadastro = valueField(sheet.Cells[row, 10].Text).validaCampo(8);
                        campos.Funcionario = valueField(sheet.Cells[row, 11].Text).validaCampo(6);
                        campos.Nome = valueField(sheet.Cells[row, 12].Text).validaCampo(100);
                        campos.NumArm = valueField(sheet.Cells[row, 13].Text).validaCampo(6);
                        campos.NumGav = valueField(sheet.Cells[row, 14].Text).validaCampo(6);
                        campos.Localização = valueField(sheet.Cells[row, 15].Text).validaCampo(20);
                        campos.CodSet = valueField(sheet.Cells[row, 16].Text).validaCampo(6);
                        campos.DescSetor = valueField(sheet.Cells[row, 17].Text).validaCampo(20);
                        campos.Filial = valueField(sheet.Cells[row, 18].Text).validaCampo(2);
                        campos.NovoContrato = valueField(sheet.Cells[row, 19].Text).validaCampo(6);
                        campos.Contrato = valueField(sheet.Cells[row, 20].Text).validaCampo(50);

                        objretorno.Add(campos);
                        row++;
                    }
                    else
                    {
                        continuar = false;
                    }
                }
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
                if (campo == "")
                {
                    campo = "000000";
                }
            }

            if (isValid(campo))
            {
                if (date)
                {
                    campo = $"{campo.Substring(6, 4)}{campo.Substring(3, 2)}{campo.Substring(0, 2)}";
                }
            }
            return campo;
        }
       
    }
}
