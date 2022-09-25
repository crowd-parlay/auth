using System.ComponentModel.DataAnnotations;

namespace Auth.OpenIddict.Models;

public class LoginDto
{
    [Required] public string Username { get; set; }
    [Required] public string Password { get; set; }
    public string ReturnUrl { get; set; }
}