using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BancoSangueWPF.Models
{
    [Table("Hospital")]
    class Hospital:BaseModel
    {
        public string Nome_hospital { get; set; }

        public string Endereco { get; set; }

        public int Telefone { get; set; }

        public string Nome_responsavel { get; set; }
    }
}
