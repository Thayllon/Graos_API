using Graos_API.Domain.Enums;
using System;

namespace Graos_API.Domain.Models
{
    public class Pesagem_tb : EntityBase
    {
        public int PesagemID { get; set; }
        public DateTime Data_Abertura { get; set; }
        public DateTime? Data_Fechamento { get; set; }
        public string Placa { get; set; }
        public decimal Valor { get; set; }
        public decimal Peso_Inicial { get; set; }
        public decimal Peso_Final { get; set; }
        public decimal Peso_Liquido { get; set; }
        public string NF { get; set; }
        public Tipo_PesagemEnum Tipo_Pesagem { get; set; }
        public Status_PesagemEnum Status_Pesagem { get; set; }
        public string Obs { get; set; }
        public DateTime? Data_Inclusao { get; set; }
        public DateTime? Data_Alteracao { get; set; }

        public Avulsa_tb Avulsa_tb { get; set; }
        public int MotoristaID { get; set; }
        public Motorista_tb Motorista_tb { get; set; }
        public int ProdutoID { get; set; }
        public Produto_tb Produto_tb { get; set; }
        public int FornecedorID { get; set; }
        public Fornecedor_tb Fornecedor_tb { get; set; }
    }
}
