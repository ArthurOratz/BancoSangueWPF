using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BancoSangueWPF.Models
{
    [Table("Doador")]
    class Doador : Pessoa
    {
        public Doador()
        {
            CriadoEm = DateTime.Now;

            TipoSanguineo = new TipoSanguineo();
        }

        public TipoSanguineo TipoSanguineo { get; set; }

        public double Peso { get; set; }
        
        public string Sexo { get; set; }

        public List<Coleta> ListaColetas { get; set; }
    }
}
