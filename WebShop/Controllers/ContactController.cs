using Microsoft.AspNetCore.Mvc;
using WebShop.Contexts;
using WebShop.ViewModels;

namespace WebShop.Controllers;

public class ContactController : Controller
{
    private readonly WebAppContext _context;

    public ContactController(WebAppContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(ContactViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await _context.ContactMessages.AddAsync(model);
        await _context.SaveChangesAsync();

        return RedirectToAction("sent");
    }

    public IActionResult Sent()
    {
        return View();
    }

}
