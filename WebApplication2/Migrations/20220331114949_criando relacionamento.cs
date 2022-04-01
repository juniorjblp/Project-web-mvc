using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class criandorelacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "produtoId",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_produtoId",
                table: "Clientes",
                column: "produtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Produtos_produtoId",
                table: "Clientes",
                column: "produtoId",
                principalTable: "Produtos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Produtos_produtoId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_produtoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "produtoId",
                table: "Clientes");
        }
    }
}
