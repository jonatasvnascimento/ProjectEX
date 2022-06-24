using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEX.model
{
    public class CamposExcelModel
    {
        public string Indice { get; set; }
        public string Barra { get; set; }
        public string NovoProduto_ { get; set; }
        public string ItemCtr_ { get; set; }
        public string Enxoval { get; set; }
        public string Descricao { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public string QtdHigienizações { get; set; }
        public string Cadastro { get; set; }
        public string Funcionario { get; set; }
        public string Nome { get; set; }
        public string NumArm_ { get; set; }
        public string NumGav_ { get; set; }
        public string Localização { get; set; }
        public string CodSet { get; set; }
        public string DescSetor { get; set; }
        public string Filial_ { get; set; }
        public string NovoContrato_ { get; set; }
        public string Contrato { get; set; }
        public string Cliente { get; set; }
        [NotMapped]
        public string SQL { get { return
                        $"('', " +
                        $"'{Barra}', " +
                        $"'{NovoProduto_}', " +
                        $"'{Enxoval}', " +
                        $"'{Descricao}', " +
                        $"'{Tamanho}', " +
                        $"'{QtdHigienizações}', " +
                        $"'{Cadastro}', " +
                        $"'{Funcionario}', " +
                        $"'{Nome}', " +
                        $"'{NumArm_}', " +
                        $"'', " +
                        $"'', " +
                        $"'{NovoContrato_}', " +
                        $"'{Contrato}', " +
                        $"'{Filial_}', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'{ItemCtr_}', " +
                        $"'', " +
                        $"'{NumGav_}', " +
                        $"'', " +
                        $"'', " +
                        $"'{Localização}'),";
            }}
    }
}
