using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaDoTioBill.Migrations
{
    public partial class Versao10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rota_Cliente_IdCliente",
                table: "Rota");

            migrationBuilder.DropIndex(
                name: "IX_Rota_IdCliente",
                table: "Rota");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Rota");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Rota",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rota_IdCliente",
                table: "Rota",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Rota_Cliente_IdCliente",
                table: "Rota",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
