using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BancoSangueWPF.Models
{
    [Table("Doador")]
    class Doardor : Pessoa
    {
        public string Tipo_sanguineo { get; set; }

        public int Peso { get; set; }
    }
}
