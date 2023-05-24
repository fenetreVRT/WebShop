using Microsoft.AspNetCore.Mvc;
using WebShop.Contexts;
using WebShop.Models.Entities;

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
    public async Task<IActionResult> Index(ContactMessageEntity model)
    {
        if (ModelState.IsValid)
        {
            _context.Add(model);
            _context.SaveChanges();


            return RedirectToAction("index");


        }
        ModelState.AddModelError("", "Submit a message");

        return View(model);
    }

}
