/*using WebShop.Contexts;
using WebShop.Models.Dtos;
using WebShop.Models.Entities;

namespace WebShop.Services;

public class FormService
{
    private readonly WebAppContext _context;

    public async Task<ContactMessageDto> AddAsync(AppUserEntity formProfile)
    {
        var _form = await _context.AddAsync(formProfile);
        await _context.SaveChangesAsync();

        return _form;
    }
}
*/