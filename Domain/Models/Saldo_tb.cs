using System;

namespace Graos_API.Domain.Models
{
    public class Saldo_tb : EntityBase
    {
        public int SaldoID { get; set; }
        public decimal Saldo_Entrada { get; set; }
        public decimal Saldo_Saida { get; set; }
        public decimal Saldo_Disponivel { get; set; }
        public string Obs { get; set; }
        public DateTime? Data_Inclusao { get; set; }
        public DateTime? Data_Alteracao { get; set; }

        public int FornecedorID { get; set; }
        public Fornecedor_tb Fornecedor_tb { get; set; }
    }
}
