using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShop.Services;
using WebShop.ViewModels;

namespace WebShop.Controllers;

public class AccountController : Controller
{
    private readonly AuthService _auth;

    public AccountController(AuthService auth)
    {
        _auth = auth;
    }

    [Authorize]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Registration()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Registration(UserRegistrationViewModel model)
    {
        if (ModelState.IsValid)
        {
            if (await _auth.RegistrationAsync(model))
                return RedirectToAction("Registration");

            ModelState.AddModelError("", "A user with the same e-mail already exists");
        }

        return View(model);
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
        if (ModelState.IsValid)
        {
            if (await _auth.LogInAsync(model))
                return RedirectToAction("index");

            ModelState.AddModelError("", "Incorrect email or password");
        }

        return View(model);
    }

    [Authorize]
    public async Task<IActionResult> LogOut()
    {
        if (await _auth.LogOutAsync(User))
            return LocalRedirect("/");

        return RedirectToAction("Index");
    }

}
