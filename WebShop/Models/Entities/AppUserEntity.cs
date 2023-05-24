using Microsoft.AspNetCore.Identity;

namespace WebShop.Models.Entities;

public class AppUserEntity : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

}
