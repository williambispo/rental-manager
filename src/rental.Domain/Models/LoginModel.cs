using System.ComponentModel.DataAnnotations;

namespace rental.Domain.Models;

public class LoginModel
{
    [Required(ErrorMessage = "Nome do usuário é obrigatório")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Senha é obrigatória")]
    public string? Password { get; set; }
}