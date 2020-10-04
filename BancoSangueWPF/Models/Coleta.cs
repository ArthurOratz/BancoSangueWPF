using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSangueWPF.Models
{
    class Coleta:BaseModel
    {
        public Doardor Doador { get; set; }

        public Funcionario Funcionario { get; set; }

        public DateTime Data { get; set; }

        public TipoSanguineo TipoSanguineo { get; set; }

        public int QuantidadeDoada { get; set; }
    }
}
