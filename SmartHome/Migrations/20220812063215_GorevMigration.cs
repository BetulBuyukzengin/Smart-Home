using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartHome.Migrations
{
    public partial class GorevMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormPhone",
                table: "Partners_Con");

            migrationBuilder.DropColumn(
                name: "FormPosta",
                table: "Partners_Con");

            migrationBuilder.DropColumn(
                name: "FormText",
                table: "Partners_Con");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormPhone",
                table: "Partners_Con",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormPosta",
                table: "Partners_Con",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormText",
                table: "Partners_Con",
                type: "text",
                nullable: true);
        }
    }
}
