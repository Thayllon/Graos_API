using System;
using System.Collections.Generic;

namespace Graos_API.Domain.Models
{
    public class Fornecedor_tb : EntityBase
    {
        public int FornecedorID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Obs { get; set; }
        public DateTime? Data_Inclusao { get; set; }
        public DateTime? Data_Alteracao { get; set; }

        public IEnumerable<Propriedade_tb> Propriedade_tb { get; private set; }
        public IEnumerable<Pesagem_tb> Pesagem_tb { get; private set; }
        public Saldo_tb Saldo_tb { get; private set; }
    }
}
