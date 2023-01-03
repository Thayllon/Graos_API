using System;

namespace Graos_API.Domain.Models
{
    public class Propriedade_tb : EntityBase
    {
        public int PropriedadeID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Obs { get; set; }
        public DateTime? Data_Inclusao { get; set; }
        public DateTime? Data_Alteracao { get; set; }

        public int FornecedorID { get; set; }
        public Fornecedor_tb Fornecedor_tb { get; set; }
    }
}
