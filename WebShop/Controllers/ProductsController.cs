using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Contexts;

namespace WebShop.Controllers;

public class ProductsController : Controller
{
    private readonly WebAppContext _context;

    public ProductsController(WebAppContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {

        return View(await _context.Products.ToListAsync());
    }

    [HttpGet("products/{id}")]
    public async Task<IActionResult> Details(int id)
    {

        return View(await _context.Products.FindAsync(id));
    }

}
