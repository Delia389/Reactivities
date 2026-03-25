using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    public string DisplayName { get; set; } = "";

    [EmailAddress]
    [Required]
    public string Email { get; set; } = "";

    public string Password { get; set; } = "";
}
