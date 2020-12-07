﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    public class Doador : BaseModel
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public double Peso { get; set; }

        [ForeignKey("TipoSanguineoId")]
        public TipoSanguineo TipoSanguineo { get; set; }

        public int TipoSanguineoId { get; set; }
    }
}
