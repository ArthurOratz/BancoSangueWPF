using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSangueWPF.Models
{
    class Pessoa : BaseModel
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

        public int Telefone { get; set; }
        public string Sexo { get; set; }
    }
}
