using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    public class Coleta : BaseModel
    {
        public double Quantidade { get; set; }

        public DateTime Data { get; set; }

        [ForeignKey("DoadorId")]
        public Doador Doador { get; set; }

        public int DoadorId { get; set; }

        [ForeignKey("FuncionarioId")]
        public Funcionario Funcionario { get; set; }

        public int FuncionarioId { get; set; }

    }
}
