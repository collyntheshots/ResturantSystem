using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class Hamburgerupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://localhost:44351/Images/Hamburger.jpg", "https://localhost:44351/Images/Hamburger.jpg", "Hamburger", "What's better than a Hamburger!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://localhost:44351/Images/Hamberger.jpg", "https://localhost:44351/Images/Hamberger.jpg", "Hamberger", "What's better than a Hamberger!" });
        }
    }
}
