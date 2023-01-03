using System;

namespace Graos_API.Domain.Models
{
    public class Avulsa_tb : EntityBase
    {
        public int AvulsaID { get; set; }
        public decimal Valor { get; set; }
        public bool Pago { get; set; }
        public string Obs { get; set; }
        public DateTime? Data_Inclusao { get; set; }
        public DateTime? Data_Alteracao { get; set; }

        public int PesagemID { get; set; }
        public Pesagem_tb Pesagem_tb { get; set; }
    }
}
