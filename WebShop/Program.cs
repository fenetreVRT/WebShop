// Produkter och kontaktformulär

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebShop.Contexts;
using WebShop.Factories;
using WebShop.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<WebAppContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("WebShopDatabase")));
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<SeedService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>(x =>
    {
        x.SignIn.RequireConfirmedAccount = false;
        x.Password.RequiredLength = 8;
        x.User.RequireUniqueEmail = true;

    })
        .AddEntityFrameworkStores<WebAppContext>()
        .AddClaimsPrincipalFactory<CustomClaimsPricipalFactory>();





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
