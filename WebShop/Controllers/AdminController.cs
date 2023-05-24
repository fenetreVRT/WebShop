using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShop.ViewModels;

namespace WebShop.Controllers;

[Authorize(Roles = "admin")]
public class AdminController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;

    public AdminController(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var admins = await _userManager.GetUsersInRoleAsync("admin");
        var user = await _userManager.GetUsersInRoleAsync("user");

        var model = new AdminViewModel
        {
            admins = admins,
            user = user
        };

        return View(model);
    }
}
