using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    public class Doador : BaseModel
    {
        public string Nome{ get; set; }

        public string Cpf{ get; set; }

        public string Email{ get; set; }

        public int Telefone{ get; set; }

        public string TipoSanguineo { get; set; }

        public int Peso { get; set; }
    }
}
