using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class Updatedbinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "Price", "ShortDescription" },
                values: new object[] { "https://localhost:44351/Images/Cheesesticks.jpg", "https://localhost:44351/Images/Cheesesticks.jpg", "Cheese Sticks", 5.95m, "Our amazing Cheese Sticks!" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Tacos", 10.95m });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3,
                columns: new[] { "Name", "ShortDescription" },
                values: new object[] { "Hamberger", "What's better than a Hamberger!" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://localhost:44351/Images/Kormeatonstick.jpg", "https://localhost:44351/Images/Kormeatonstick.jpg", "Korean Meat on a Stick", "The best Korean Meat on a stick that you can get in the US" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://localhost:44351/Images/Meatpie.jpg", "https://localhost:44351/Images/Meatpie.jpg", "Meat pies", "Nigerian Meat pies" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://localhost:44351/Images/Nachos.jpg", "https://localhost:44351/Images/Nachos.jpg", "Nachos", "Nachos, does anything more have to be said" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://localhost:44351/Images/Sliders.jpg", "https://localhost:44351/Images/Sliders.jpg", "Sliders", "Turkey Sliders" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "Price", "ShortDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", "Apple Pie", 12.95m, "Our famous apple pies!" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Blueberry Cheese Cake", 18.95m });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3,
                columns: new[] { "Name", "ShortDescription" },
                values: new object[] { "Cheese Cake", "Plain cheese cake. Plain pleasure." });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", "Cherry Pie", "A summer classic!" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", "Peach Pie", "Sweet as peach" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", "Rhubarb Pie", "My God, so sweet!" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", "Strawberry Pie", "Our delicious strawberry pie!" });
        }
    }
}
