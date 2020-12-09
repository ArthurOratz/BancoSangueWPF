using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    public class TipoSanguineo : BaseModel
    {
        public string FatorRH { get; set; }

        public string Tipo { get; set; }

        public override string ToString()
        {
            return Tipo + FatorRH;
        }
    }
}
