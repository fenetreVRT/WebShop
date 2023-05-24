﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using WebShop.Services;

namespace WebShop.Factories;

public class CustomClaimsPricipalFactory : UserClaimsPrincipalFactory<IdentityUser>
{
    private readonly UserService _userService;
    public CustomClaimsPricipalFactory(UserManager<IdentityUser> userManager, IOptions<IdentityOptions> optionsAccessor, UserService userService) : base(userManager, optionsAccessor)
    {
        _userService = userService;
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
    {
        var claimsIdentity = await base.GenerateClaimsAsync(user);

        var roles = await UserManager.GetRolesAsync(user);
        claimsIdentity.AddClaims(roles.Select(x => new Claim(ClaimTypes.Role, x)));

        var userProfileEntity = await _userService.GetUserProfileAsync(user.Id);
        claimsIdentity.AddClaim(new Claim("DisplayName", $"{userProfileEntity.FirstName} {userProfileEntity.LastName}"));

        return claimsIdentity;

    }
}
