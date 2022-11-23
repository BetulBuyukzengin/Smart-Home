using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SmartHome.Migrations
{
    public partial class Smarthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    KullaniciAdi = table.Column<string>(type: "text", nullable: true),
                    KullaniciSifre = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Baner6s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Solbaslik1 = table.Column<string>(type: "text", nullable: true),
                    Solaciklama = table.Column<string>(type: "text", nullable: true),
                    Callnow = table.Column<int>(type: "int", nullable: false),
                    Yname = table.Column<string>(type: "text", nullable: true),
                    Eml = table.Column<string>(type: "text", nullable: true),
                    Msg = table.Column<string>(type: "text", nullable: true),
                    Submit = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baner6s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banner2s",
                columns: table => new
                {
                    Idbanner2 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Bn2text = table.Column<string>(type: "text", nullable: true),
                    CardText1 = table.Column<string>(type: "text", nullable: true),
                    CardText2 = table.Column<string>(type: "text", nullable: true),
                    CardText3 = table.Column<string>(type: "text", nullable: true),
                    CardText4 = table.Column<string>(type: "text", nullable: true),
                    CardText5 = table.Column<string>(type: "text", nullable: true),
                    CardText6 = table.Column<string>(type: "text", nullable: true),
                    CardText7 = table.Column<string>(type: "text", nullable: true),
                    CardText8 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banner2s", x => x.Idbanner2);
                });

            migrationBuilder.CreateTable(
                name: "hq_Technologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hq_Technologies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciTablo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Posta = table.Column<string>(type: "text", nullable: true),
                    Mesaj = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciTablo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Swipers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Centered1 = table.Column<string>(type: "text", nullable: true),
                    Centered2 = table.Column<string>(type: "text", nullable: true),
                    Centered3 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Swipers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yorums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Etiket = table.Column<string>(type: "text", nullable: true),
                    Etiketbaslik = table.Column<string>(type: "text", nullable: true),
                    Cardtext1 = table.Column<string>(type: "text", nullable: true),
                    Sahibi1 = table.Column<string>(type: "text", nullable: true),
                    Sahibi2 = table.Column<string>(type: "text", nullable: true),
                    Cardtext2 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorums", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Baner6s");

            migrationBuilder.DropTable(
                name: "Banner2s");

            migrationBuilder.DropTable(
                name: "hq_Technologies");

            migrationBuilder.DropTable(
                name: "KullaniciTablo");

            migrationBuilder.DropTable(
                name: "Swipers");

            migrationBuilder.DropTable(
                name: "Yorums");
        }
    }
}
