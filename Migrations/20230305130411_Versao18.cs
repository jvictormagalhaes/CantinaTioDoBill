using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaDoTioBill.Migrations
{
    public partial class Versao18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TelaVenda",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeItem = table.Column<string>(type: "TEXT", nullable: false),
                    IdProduto = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorUnitario = table.Column<double>(type: "REAL", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelaVenda", x => x.IdItem);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TelaVenda");
        }
    }
}
