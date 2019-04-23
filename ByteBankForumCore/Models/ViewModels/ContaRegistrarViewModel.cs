using System.ComponentModel.DataAnnotations;

namespace ByteBankForumCore.Models.ViewModels
{
    public class ContaRegistrarViewModel
    {

        [Required(ErrorMessage = "Nome do usuário é obrigatório!")]
        [MinLength(5, ErrorMessage = "Nome do usuário deve conter no mínimo 5 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome do usuário deve conter no máximo 50 caracteres")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Nome completo")]
        [MinLength(5, ErrorMessage = "Nome completo deve conter no mínimo 5 caracteres")]
        [MaxLength(200, ErrorMessage = "Nome do usuário deve conter no máximo 200 caracteres")]
        public string NomeCompleto { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido!")]
        public string Email { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Nome completo deve conter no mínimo 5 caracteres")]
        [MaxLength(20, ErrorMessage = "Nome do usuário deve conter no máximo 20 caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
