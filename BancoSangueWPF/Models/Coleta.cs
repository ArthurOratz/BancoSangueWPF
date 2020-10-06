using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoSangueWPF.Models
{
    [Table("Coleta")]
    class Coleta : BaseModel
    {
        public Doador Doador { get; set; }

        public Funcionario Funcionario { get; set; }

        public DateTime Data { get; set; }
        public TipoSanguineo TipoSanguineo { get; set; }
        public int Quantidade { get; set; }
    }
}
