using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BancoSangueWPF.Models
{
    [Table("Tipo_Sanguineo")]
    class TipoSanguineo:BaseModel
    {
        public string Fator_RH { get; set; }

        public string Tipo_sanguineo { get; set; }
    }
}
