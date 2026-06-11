using System.ComponentModel.DataAnnotations;


namespace ProjetoWeb01.Classes.Contratos
{
    public class LoginModel
    {
        [Required(ErrorMessage = "0 e-mail é obrigatorio.")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido")]

        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [MinLength(6, ErrorMessage = "A senha deve ter no minimo 6 caracteres")]
        public string Senha { get; set; } = string.Empty;
    }
}
