using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models.Entities;
using WebShop.ViewModels;

namespace WebShop.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<AppUserEntity> _userManager;
    private readonly SignInManager<AppUserEntity> _signInManager;

    public AccountController(UserManager<AppUserEntity> userManager, SignInManager<AppUserEntity> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [Authorize]
    public async Task<IActionResult> Index()
    {
        var user = await _userManager.FindByNameAsync(User.Identity?.Name ?? "");
        if (user is null)
            return RedirectToAction("Login");

        return View(new AccountViewModel(user));
    }

    public IActionResult Registration()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Registration(UserRegistrationViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        AppUserEntity user = model;
        var result = await _userManager.CreateAsync(user, model.Password);
        if (!result.Succeeded)
        {
            result.Errors.ToList().ForEach(error => ModelState.AddModelError("", error.Description));
            return View(model);
        }

        if (_userManager.Users.Count() == 1)
        {
            await _userManager.AddToRoleAsync(user, "admin");
        }
        else
        {
            await _userManager.AddToRoleAsync(user, "customer");
        }

        return RedirectToAction("login");
    }

    //Send user to view
    public IActionResult LogIn()
    {
        return View();
    }

    //Send result from view back to database
    [HttpPost]
    public async Task<IActionResult> LogIn(UserLogInViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
        if (!result.Succeeded)
        {
            ModelState.AddModelError("", "Incorrect email or password");
            return View(model);
        }
        return RedirectToAction("index");
    }

    [Authorize]
    public async Task<IActionResult> LogOut()
    {
        await _signInManager.SignOutAsync();
        return LocalRedirect("/");
    }
}
