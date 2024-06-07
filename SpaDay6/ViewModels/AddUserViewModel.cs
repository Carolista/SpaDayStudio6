using System.ComponentModel.DataAnnotations;

namespace SpaDay6;

public class AddUserViewModel
{
    [Required(ErrorMessage = "Username is required.")]
    [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be 5-15 characters long.")]
    public string? Username { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "Username must be 6-20 characters long.")]
    [Compare("VerifyPassword", ErrorMessage = "Passwords must match!")]
    public string? Password { get; set; }

    [StringLength(20, MinimumLength = 6, ErrorMessage = "Username must be 6-20 characters long.")]
    [Required(ErrorMessage = "Password verification is required.")]
    public string? VerifyPassword { get; set; }
}
