using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaDoTioBill.Migrations
{
    public partial class Versao5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValCompra",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "ValVenda",
                table: "Produto",
                newName: "Preco");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Cliente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produto",
                newName: "ValVenda");

            migrationBuilder.AddColumn<double>(
                name: "ValCompra",
                table: "Produto",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
