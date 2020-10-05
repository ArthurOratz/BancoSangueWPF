using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace BancoSangueWPF.Models
{
    [Table("Retirada")]
    class Retirada :EstoqueSangue
    {
        public Hospital Hospital { get; set; }
        public DateTime Data { get; set; }
    }
}
