using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebShop.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin", null, "admin", "ADMIN" },
                    { "customer", null, "customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Get a new companion?", "1.jpg", 10m, "Cat I" },
                    { 2, "Get a new companion?", "2.jpg", 12m, "Cat II" },
                    { 3, "Get a new companion?", "3.jpg", 14m, "Cat III" },
                    { 4, "Get a new companion?", "4.jpg", 15m, "Cat IV" },
                    { 5, "Get a new companion?", "5.jpg", 114m, "Cat V" },
                    { 6, "Get a new companion?", "6.jpg", 15m, "Cat VI" },
                    { 7, "Get a new companion?", "7.jpg", 111m, "Cat VII" },
                    { 8, "Get a new companion?", "8.jpg", 124m, "Cat VIII" },
                    { 9, "Get a new companion?", "9.jpg", 144m, "Cat IX" },
                    { 10, "Get a new companion?", "10.jpg", 124m, "Cat X" },
                    { 11, "Get a new companion?", "11.jpg", 154m, "Cat XI" },
                    { 12, "Get a new companion?", "12.jpg", 164m, "Cat XII" },
                    { 13, "Get a new companion?", "13.jpg", 184m, "Cat XIII" },
                    { 14, "Get a new companion?", "14.jpg", 184m, "Cat XIV" },
                    { 15, "Get a new companion?", "15.jpg", 154m, "Cat XV" },
                    { 16, "Get a new companion?", "16.jpg", 154m, "Cat XVI" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "new" },
                    { 2, "featured" },
                    { 3, "popular" }
                });

            migrationBuilder.InsertData(
                table: "ProductTag",
                columns: new[] { "ProductsId", "TagsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 5, 2 },
                    { 6, 1 },
                    { 6, 2 },
                    { 7, 1 },
                    { 7, 2 },
                    { 8, 1 },
                    { 8, 2 },
                    { 9, 2 },
                    { 9, 3 },
                    { 10, 2 },
                    { 10, 3 },
                    { 11, 2 },
                    { 11, 3 },
                    { 12, 2 },
                    { 12, 3 },
                    { 13, 3 },
                    { 14, 3 },
                    { 15, 3 },
                    { 16, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "customer");

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
