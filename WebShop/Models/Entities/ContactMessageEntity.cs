using WebShop.Models.Dtos;

namespace WebShop.Models.Entities;

public class ContactMessageEntity
{

    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string FormMessage { get; set; } = null!;

    public static implicit operator ContactMessageDto(ContactMessageEntity form)
    {
        return new ContactMessageDto
        {
            FirstName = form.FirstName,
            LastName = form.LastName,
            Email = form.Email,
            Message = form.FormMessage
        };
    }
}


