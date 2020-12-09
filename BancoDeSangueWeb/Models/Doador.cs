using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    public class Doador : BaseModel
    {
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public double Peso { get; set; }

        [ForeignKey("TipoSanguineoId")]
        public TipoSanguineo TipoSanguineo { get; set; }

        public int TipoSanguineoId { get; set; }

        public override string ToString()
        {
            return Nome + ' ' + '(' + TipoSanguineo.ToString() + ')';
        }
    }
}
