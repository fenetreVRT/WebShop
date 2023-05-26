using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Contexts;
using WebShop.ViewModels;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebAppContext _context;

        public HomeController(WebAppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var newProducts = await _context.Products.Where(p => p.Tags.Any(t => t.Name == "new")).ToListAsync();
            var popularProducts = await _context.Products.Where(p => p.Tags.Any(t => t.Name == "popular")).ToListAsync();
            var featuredProducts = await _context.Products.Where(p => p.Tags.Any(t => t.Name == "featured")).ToListAsync();

            var viewModel = new HomeViewModel
            {
                ShowCaseProduct = await _context.Products.FindAsync(1),
                ProductSections = new List<ProductSectionViewModel>
                {
                    new ProductSectionViewModel {Title = "New", Products = newProducts},
                    new ProductSectionViewModel {Title = "popular", Products = popularProducts},
                    new ProductSectionViewModel {Title = "featured", Products = featuredProducts}
                }
            };

            return View(viewModel);
        }
    }
}
