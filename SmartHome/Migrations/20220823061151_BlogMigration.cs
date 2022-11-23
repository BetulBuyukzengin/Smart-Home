using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SmartHome.Migrations
{
    public partial class BlogMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogTablosu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Baslik = table.Column<string>(type: "text", nullable: true),
                    Aciklama = table.Column<string>(type: "text", nullable: true),
                    Resim = table.Column<string>(type: "text", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    AktifPasif = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Goruntulenme = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTablosu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlokCategoryTablosu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Baslik = table.Column<string>(type: "text", nullable: true),
                    Aciklama = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlokCategoryTablosu", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogTablosu");

            migrationBuilder.DropTable(
                name: "BlokCategoryTablosu");
        }
    }
}
