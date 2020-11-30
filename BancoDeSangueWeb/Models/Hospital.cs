using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    public class Hospital : BaseModel
    {
        public string Nome{ get; set; }

        public string Endereco { get; set; }

        public int Telefone { get; set; }

        public string Nome_Responsavel { get; set; }

    }
}
