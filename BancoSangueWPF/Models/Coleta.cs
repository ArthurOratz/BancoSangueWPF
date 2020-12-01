using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoSangueWPF.Models
{
    [Table("Coleta")]
    class Coleta : BaseModel
    {
        public int DoadorID { get; set; }

        public int FuncionarioID { get; set; }

        public DateTime Data { get; set; }
        public int TipoSanguineoID { get; set; }
        public int Quantidade { get; set; }
    }
}
