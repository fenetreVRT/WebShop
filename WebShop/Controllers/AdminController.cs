using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Contexts;
using WebShop.Models.Entities;
using WebShop.ViewModels;

namespace WebShop.Controllers;

[Authorize(Roles = "admin")]
public class AdminController : Controller
{
    private readonly UserManager<AppUserEntity> _userManager;
    private readonly WebAppContext _context;

    public AdminController(UserManager<AppUserEntity> userManager, WebAppContext context)
    {
        _userManager = userManager;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var admins = await _userManager.GetUsersInRoleAsync("admin");
        var users = await _userManager.GetUsersInRoleAsync("customer");
        var messages = await _context.ContactMessages.ToListAsync();

        var model = new AdminViewModel
        {
            Admins = admins,
            Users = users,
            Messages = messages
        };

        return View(model);
    }
}
