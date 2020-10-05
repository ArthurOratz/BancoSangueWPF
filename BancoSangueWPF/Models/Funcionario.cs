using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BancoSangueWPF.Models
{
    [Table("Funcionario")]
    class Funcionario : Pessoa
    {
        public Funcionario()
        {
            CriadoEm = DateTime.Now;
        }

        public List<Coleta> ListaColetas { get; set; }
    }
}
