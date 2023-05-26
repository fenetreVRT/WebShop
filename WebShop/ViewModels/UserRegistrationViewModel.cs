using System.ComponentModel.DataAnnotations;
using WebShop.Models.Entities;

namespace WebShop.ViewModels;

public class UserRegistrationViewModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [DataType(DataType.Password)]
    [Compare(nameof(Password))]
    public string ConfirmPassword { get; set; } = null!;

    public static implicit operator AppUserEntity(UserRegistrationViewModel model)
    {
        return new AppUserEntity
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            UserName = model.Email
        };
    }
}
