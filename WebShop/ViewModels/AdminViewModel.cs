using Microsoft.AspNetCore.Identity;

namespace WebShop.ViewModels;

public class AdminViewModel
{
    public IList<IdentityUser> admins { get; set; }
    public IList<IdentityUser> user { get; set; }
}