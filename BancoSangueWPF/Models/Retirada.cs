using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace BancoSangueWPF.Models
{
    [Table("Retirada")]
    class Retirada : BaseModel
    {
        public int HospitalID { get; set; }
        public DateTime Data { get; set; }
        public int TipoSanguineoID { get; set; }
        public int Quantidade { get; set; }
    }
}
