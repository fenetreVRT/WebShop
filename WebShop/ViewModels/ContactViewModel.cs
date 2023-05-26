using System.ComponentModel.DataAnnotations;
using WebShop.Models.Entities;

namespace WebShop.ViewModels;

public class ContactViewModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;
    public string FormMessage { get; set; } = null!;

    public static implicit operator ContactMessageEntity(ContactViewModel entity)
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
