using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class UpdateFirstPic4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "D:/COP4331/WebApp/Assets/Images/Hotdog.jpg", "D:/COP4331/WebApp/Assets/Images/Hotdog.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FHot_dog&psig=AOvVaw1GZN0oEc6Rxj4sYDFWZhI1&ust=1606629524238000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNjZmcTHpO0CFQAAAAAdAAAAABAD", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FHot_dog&psig=AOvVaw1GZN0oEc6Rxj4sYDFWZhI1&ust=1606629524238000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNjZmcTHpO0CFQAAAAAdAAAAABAD" });
        }
    }
}
