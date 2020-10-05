using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoSangueWPF.Models
{
    [Table("Coleta")]
    class Coleta : EstoqueSangue
    {

        public Doador Doador { get; set; }

        public Funcionario Funcionario { get; set; }

        public DateTime Data { get; set; }
    }
}
