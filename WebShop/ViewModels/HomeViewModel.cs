using WebShop.Models.Entities;

namespace WebShop.ViewModels;

public class HomeViewModel
{
    public List<ProductSectionViewModel> ProductSections { get; set; } = new();
    public required ProductEntity? ShowCaseProduct { get; set; }

}
