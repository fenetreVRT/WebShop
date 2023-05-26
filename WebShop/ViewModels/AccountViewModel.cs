using WebShop.Models.Entities;

namespace WebShop.ViewModels;

public class AccountViewModel
{
    public AccountViewModel(AppUserEntity entity)
    {
        FirstName = entity.FirstName;
        LastName = entity.LastName;
        Email = entity.Email;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Email { get; set; }

}
