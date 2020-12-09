using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    [Table("Usuario")]
    public class UsuarioView : BaseModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Senha { get; set; }
        [Display(Name = "Confirmação da senha")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [NotMapped]
        [Compare("Senha", ErrorMessage = "Campos não coincidem")]
        public string ConfirmacaoSenha { get; set; }

    }
}
