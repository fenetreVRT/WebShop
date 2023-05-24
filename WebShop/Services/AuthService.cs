using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WebShop.Contexts;
using WebShop.Models.Entities;
using WebShop.ViewModels;

namespace WebShop.Services;

public class AuthService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly WebAppContext _identityContext;
    private readonly SeedService _seedService;

    public AuthService(UserManager<IdentityUser> userManager, WebAppContext identityContext, SignInManager<IdentityUser> signInManager, SeedService seedService, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _identityContext = identityContext;
        _signInManager = signInManager;
        _seedService = seedService;
        _roleManager = roleManager;
    }

    public async Task<bool> RegistrationAsync(UserRegistrationViewModel model)
    {
        try
        {
            await _seedService.SeedRoles();
            var roleName = "user";

            if (!await _userManager.Users.AnyAsync())
                roleName = "admin";

            IdentityUser identityUser = model;
            await _userManager.CreateAsync(identityUser, model.Password);

            await _userManager.AddToRoleAsync(identityUser, roleName);

            AppUserEntity userProfileEntity = model;
            userProfileEntity.UserId = identityUser.Id;

            _identityContext.UserProfiles.Add(userProfileEntity);
            await _identityContext.SaveChangesAsync();

            return true;
        }
        catch { return false; }
    }

    public async Task<bool> LogInAsync(UserLogInViewModel model)
    {
        try
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            return result.Succeeded;
        }

        catch { return false; }
    }

    public async Task<bool> LogOutAsync(ClaimsPrincipal user)
    {
        await _signInManager.SignOutAsync();
        return _signInManager.IsSignedIn(user);
    }

}
