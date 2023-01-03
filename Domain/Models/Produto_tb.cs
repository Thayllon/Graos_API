using System;

namespace Graos_API.Domain.Models   
{
    public class Produto_tb : EntityBase
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Safra { get; set; }
        public decimal? Umidade { get; set; }
        public string Obs { get; set; }
        public DateTime? Data_Inclusao { get; set; }
        public DateTime? Data_Alteracao { get; set; }
        public Pesagem_tb Pesagem_tb { get; set; }

    }
}
