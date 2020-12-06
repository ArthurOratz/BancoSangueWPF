using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    public class Hospital : BaseModel
    {
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MinLength(5, ErrorMessage = "Mínimo 5 caracteres!")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int Telefone { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MinLength(5, ErrorMessage = "Mínimo 5 caracteres!")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres!")]
        public string Nome_Responsavel { get; set; }

    }
}
