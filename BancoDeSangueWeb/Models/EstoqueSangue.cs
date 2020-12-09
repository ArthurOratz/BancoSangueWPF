using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    public class EstoqueSangue : BaseModel
    {
        [ForeignKey("TipoSanguineoId")]
        public TipoSanguineo TipoSanguineo { get; set; }

        public int TipoSanguineoId { get; set; }

        public double Quantidade { get; set; }
    }
}
