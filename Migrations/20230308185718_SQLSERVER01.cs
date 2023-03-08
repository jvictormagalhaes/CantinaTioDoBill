using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantinaDoTioBill.Migrations
{
    public partial class SQLSERVER01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Vendas_VendaId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_VendaId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "Produto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "Produto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_VendaId",
                table: "Produto",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Vendas_VendaId",
                table: "Produto",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "Id");
        }
    }
}
