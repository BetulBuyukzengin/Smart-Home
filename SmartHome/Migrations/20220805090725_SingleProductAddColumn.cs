using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartHome.Migrations
{
    public partial class SingleProductAddColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Urun_fiyat_2",
                table: "SingleProducts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Urun_ozellik_2",
                table: "SingleProducts",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Urun_fiyat_2",
                table: "SingleProducts");

            migrationBuilder.DropColumn(
                name: "Urun_ozellik_2",
                table: "SingleProducts");
        }
    }
}
