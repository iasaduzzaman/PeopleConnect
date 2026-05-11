using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PeopleConnect.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedPosttoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Address", "Contact", "Description", "ImageUrl", "Name", "PostTitle", "PostType" },
                values: new object[,]
                {
                    { 1, "Mirpur, Dhaka", "01712345678", "I have arranged cooked meals for 50 families in need. Anyone facing food shortages can contact me for support.", "https://images.unsplash.com/photo-1488521787991-ed7bbaae773c", "Ahnaf", "Free Food Distribution for Poor Families", "I Want to Give" },
                    { 2, "Farmgate, Dhaka", "01732678932", "Looking for warm winter clothing for my family of 4. Jackets, sweaters, gloves - anything to help us through the cold season.", "https://unsplash.com/photos/man-holding-his-leather-jacket-P0W27GRvyww", "Abrar", "Winter Clothes Needed for Family", "I Need Help" },
                    { 3, "Thakugoan, Rangpur", "01512345678", "I have school bags, notebooks, and stationery items for students from low-income families.", "https://images.unsplash.com/photo-1503676260728-1c00da094a0b", "Akash", "School Bag and Stationery Donation", "I Want to Give" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);
        }
    }
}
