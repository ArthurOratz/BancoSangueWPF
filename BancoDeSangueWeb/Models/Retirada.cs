using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    public class Retirada : BaseModel
    {
        public double Quantidade { get; set; }

        public DateTime Data { get; set; }

        [ForeignKey("TipoSanguineoId")]
        public TipoSanguineo TipoSanguineo { get; set; }

        public int TipoSanguineoId { get; set; }

        [ForeignKey("HospitalId")]
        public Hospital Hospital { get; set; }

        public int HospitalId { get; set; }
    }
}
