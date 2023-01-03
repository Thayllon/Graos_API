using System;
using System.ComponentModel.DataAnnotations;

namespace Graos_API.Domain.Models
{
    public class LogRequisicoes_tb : EntityBase
    {
        [Required]
        public DateTime RequestTime { get; set; }

        [Required]
        public long ResponseMillis { get; set; }

        [Required]
        public int StatusCode { get; set; }

        [Required]
        public string Method { get; set; }

        [Required]
        public string Path { get; set; }

        public string QueryString { get; set; }

        public string RequestBody { get; set; }

        public string ResponseBody { get; set; }

        [Key]
        public Guid User { get; set; }
    }

}
