using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaDoTioBill.Migrations
{
    public partial class Versao11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Cliente_IdClienteId",
                table: "Vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Cliente_NomeClienteId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_IdClienteId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_NomeClienteId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "IdClienteId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "NomeClienteId",
                table: "Vendas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdClienteId",
                table: "Vendas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NomeClienteId",
                table: "Vendas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_IdClienteId",
                table: "Vendas",
                column: "IdClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_NomeClienteId",
                table: "Vendas",
                column: "NomeClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Cliente_IdClienteId",
                table: "Vendas",
                column: "IdClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Cliente_NomeClienteId",
                table: "Vendas",
                column: "NomeClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
