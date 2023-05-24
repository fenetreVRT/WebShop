using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.Models.Entities;

namespace WebShop.Contexts;

public class WebAppContext : IdentityDbContext<AppUserEntity>
{

    public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
    {
    }
    public DbSet<ContactMessageEntity> Forms { get; set; }

}
