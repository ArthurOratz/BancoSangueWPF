using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    public class Coleta : BaseModel
    {
        public Funcionario Funcionario { get; set; }

        public Doador Doador { get; set; }

        public TipoSanguineo TipoSanguineo { get; set; }

        public double Quantidade { get; set; }

        public DateTime Data { get; set; }

    }
}
