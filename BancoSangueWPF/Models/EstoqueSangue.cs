using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BancoSangueWPF.Models
{
    [Table("EstoqueSangue")]
    class EstoqueSangue:BaseModel
    {
        public TipoSanguineo TipoSanguineo { get; set; }

        public int Quantidade { get; set; }

    }
}
