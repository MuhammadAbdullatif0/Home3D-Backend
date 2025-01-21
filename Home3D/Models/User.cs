using Microsoft.AspNetCore.Identity;

namespace Home3D.Models;

public class User : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
