using WebShop.Models.Entities;

namespace WebShop.ViewModels;

public class AdminViewModel
{
    public required IList<AppUserEntity> Admins { get; set; }
    public required IList<AppUserEntity> Users { get; set; }
    public required IList<ContactMessageEntity> Messages { get; set; }
}