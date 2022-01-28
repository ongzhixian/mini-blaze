using System.ComponentModel.DataAnnotations;

namespace Blaze.Models;

public class LoginModel
{
    [Required]
    [StringLength(10, ErrorMessage = "Name is too long.")]
    public string Username { get; set; } = string.Empty;

    [Required]
    [StringLength(50, ErrorMessage = "Password is too long.")]
    public string Password { get; set; } = string.Empty;
}
