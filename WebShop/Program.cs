// Produkter och kontaktformulär

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebShop.Contexts;
using WebShop.Models.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<WebAppContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("WebShopDatabase")));
builder.Services.AddIdentity<AppUserEntity, IdentityRole>(x =>
    {
        x.SignIn.RequireConfirmedAccount = false;
        x.Password.RequiredLength = 3;
        x.Password.RequireNonAlphanumeric = false;
        x.Password.RequireDigit = false;
        x.Password.RequireUppercase = false;
        x.User.RequireUniqueEmail = true;

    }).AddEntityFrameworkStores<WebAppContext>();







var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
