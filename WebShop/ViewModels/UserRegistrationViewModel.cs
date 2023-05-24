using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using WebShop.Models.Entities;

namespace WebShop.ViewModels;

public class UserRegistrationViewModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;
    public string? PhoneNumber { get; set; }

    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [DataType(DataType.Password)]
    [Compare(nameof(Password))]
    public string ConfirmPassword { get; set; } = null!;
    public string? StreetName { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }


    public static implicit operator IdentityUser(UserRegistrationViewModel model)
    {
        return new IdentityUser
        {
            UserName = model.Email,
            Email = model.Email,
            PhoneNumber = model.PhoneNumber,
        };
    }

    public static implicit operator AppUserEntity(UserRegistrationViewModel model)
    {
        return new AppUserEntity
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            StreetName = model.StreetName,
            PostalCode = model.PostalCode,
            City = model.City,
        };
    }
}
