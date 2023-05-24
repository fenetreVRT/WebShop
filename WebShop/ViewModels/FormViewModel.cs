using WebShop.Models.Entities;

namespace WebShop.ViewModels;

public class FormViewModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string FormMessage { get; set; } = null!;

    public static implicit operator ContactMessageEntity(FormViewModel entity)
    {
        return new ContactMessageEntity
        {
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
            FormMessage = entity.FormMessage
        };
    }
}
