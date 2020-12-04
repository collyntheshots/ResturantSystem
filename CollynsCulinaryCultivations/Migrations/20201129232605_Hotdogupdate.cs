using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class Hotdogupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11,
                columns: new[] { "Name", "ShortDescription" },
                values: new object[] { "Hotdogs", "Can never go wrong with a good american dog" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11,
                columns: new[] { "Name", "ShortDescription" },
                values: new object[] { "Strawberry Cheese Cake", "You'll love it!" });
        }
    }
}
