using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSangueWPF.Models
{
    class Retirada :BaseModel
    {
        public Hospital Hospital { get; set; }

        public DateTime Data { get; set; }

        public TipoSanguineo TipoSanguineo { get; set; }

        public int QuantidadeDoada { get; set; }
    }
}
