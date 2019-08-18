using Microsoft.EntityFrameworkCore.Migrations;

namespace BitacoraApp.API.Migrations
{
    public partial class ope : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Divicions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Num1 = table.Column<int>(nullable: false),
                    Num2 = table.Column<int>(nullable: false),
                    operacion = table.Column<string>(nullable: true),
                    resultado = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divicions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exponencials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Num1 = table.Column<int>(nullable: false),
                    Num2 = table.Column<int>(nullable: false),
                    operacion = table.Column<string>(nullable: true),
                    resultado = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exponencials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Multis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Num1 = table.Column<int>(nullable: false),
                    Num2 = table.Column<int>(nullable: false),
                    operacion = table.Column<string>(nullable: true),
                    resultado = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Raiz_",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Num1 = table.Column<int>(nullable: false),
                    Num2 = table.Column<int>(nullable: false),
                    operacion = table.Column<string>(nullable: true),
                    resultado = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raiz_", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Num1 = table.Column<int>(nullable: false),
                    Num2 = table.Column<int>(nullable: false),
                    operacion = table.Column<string>(nullable: true),
                    resultado = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sumas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Num1 = table.Column<int>(nullable: false),
                    Num2 = table.Column<int>(nullable: false),
                    operacion = table.Column<string>(nullable: true),
                    resultado = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sumas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Divicions");

            migrationBuilder.DropTable(
                name: "Exponencials");

            migrationBuilder.DropTable(
                name: "Multis");

            migrationBuilder.DropTable(
                name: "Raiz_");

            migrationBuilder.DropTable(
                name: "Restas");

            migrationBuilder.DropTable(
                name: "Sumas");
        }
    }
}
