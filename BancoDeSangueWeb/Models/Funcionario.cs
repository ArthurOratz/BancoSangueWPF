using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    public class Funcionario : BaseModel
    {
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Nome{ get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Cpf{ get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Email{ get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Telefone{ get; set; }
    }
}
