using WebShop.Models.Entities;

namespace WebShop.ViewModels;

public class ProductSectionViewModel
{
    public required string Title { get; set; }
    public List<ProductEntity> Products { get; set; } = new();
}
