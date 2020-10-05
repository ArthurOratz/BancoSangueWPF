using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BancoSangueWPF.Models
{
    [Table("Hospital")]
    class Hospital : BaseModel
    {
        public Hospital()
        {
            CriadoEm = DateTime.Now;
        }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string NomeResponsavel { get; set; }

        public List<Retirada> ListaRetiradas { get; set; }
    }
}
