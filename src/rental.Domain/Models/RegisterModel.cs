using System.ComponentModel.DataAnnotations;

namespace rental.Domain.Models;

public class RegisterModel
{
    [Required(ErrorMessage = "Nome do Usuário é obrigatório!")]
    public string? Username { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "Email é obrigatório!")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Senha é obrigatória!")]
    public string? Password { get; set; }
}