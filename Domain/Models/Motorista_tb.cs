using System;

namespace Graos_API.Domain.Models
{
    public class Motorista_tb : EntityBase
    {
        public int MotoristaID { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Placa2 { get; set; }
        public string Cpf_Cnpj { get; set; }
        public string Obs { get; set; }
        public DateTime? Data_Inclusao { get; set; }
        public DateTime? Data_Alteracao { get; set; }
        public Pesagem_tb Pesagem_tb { get; set; }
    }
}
