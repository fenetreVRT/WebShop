using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebShop.Models.Entities;

namespace WebShop.Helpers;

public static class Seeder
{
    class ProductTag
    {
        public int ProductsId { get; set; }
        public int TagsId { get; set; }
    }

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = "admin", Name = "admin", NormalizedName = "ADMIN" },
            new IdentityRole { Id = "customer", Name = "customer", NormalizedName = "CUSTOMER" }
            );

        builder.Entity<TagEntity>().HasData(
            new TagEntity { Id = 1, Name = "new" },
            new TagEntity { Id = 2, Name = "featured" },
            new TagEntity { Id = 3, Name = "popular" }
            );

        builder.Entity<ProductEntity>().HasData(
            new ProductEntity { Id = 1, Title = "Cat I", Price = 10, Image = "1.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 2, Title = "Cat II", Price = 12, Image = "2.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 3, Title = "Cat III", Price = 14, Image = "3.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 4, Title = "Cat IV", Price = 15, Image = "4.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 5, Title = "Cat V", Price = 114, Image = "5.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 6, Title = "Cat VI", Price = 15, Image = "6.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 7, Title = "Cat VII", Price = 111, Image = "7.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 8, Title = "Cat VIII", Price = 124, Image = "8.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 9, Title = "Cat IX", Price = 144, Image = "9.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 10, Title = "Cat X", Price = 124, Image = "10.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 11, Title = "Cat XI", Price = 154, Image = "11.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 12, Title = "Cat XII", Price = 164, Image = "12.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 13, Title = "Cat XIII", Price = 184, Image = "13.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 14, Title = "Cat XIV", Price = 184, Image = "14.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 15, Title = "Cat XV", Price = 154, Image = "15.jpg", Description = "Get a new companion?" },
            new ProductEntity { Id = 16, Title = "Cat XVI", Price = 154, Image = "16.jpg", Description = "Get a new companion?" }
            );

        // Create CategoryProducts for seeding
        var productTags = new List<ProductTag>();
        for (var i = 0; i < 3; i++)
        {
            for (var j = 1 + i * 4; j <= 8 + i * 4; j++)
            {
                productTags.Add(new ProductTag { ProductsId = j, TagsId = i + 1 });
            }
        }
        builder.Entity("ProductTag").HasData(productTags);
    }

}
