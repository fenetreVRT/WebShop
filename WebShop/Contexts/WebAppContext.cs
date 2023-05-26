using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.Helpers;
using WebShop.Models.Entities;

namespace WebShop.Contexts;

public class WebAppContext : IdentityDbContext<AppUserEntity>
{
    public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
    {
    }
    public DbSet<ContactMessageEntity> ContactMessages { get; set; }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<TagEntity> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<ProductEntity>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Products)
                .UsingEntity("ProductTag");
        Seeder.Seed(builder);
    }


}
