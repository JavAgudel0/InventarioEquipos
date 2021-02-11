using Microsoft.EntityFrameworkCore.Migrations;

namespace InventariosEquipos.Web.Migrations
{
    public partial class Marca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarcaEquipo",
                table: "Equipos");

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Equipos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_MarcaId",
                table: "Equipos",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Marcas_MarcaId",
                table: "Equipos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Marcas_MarcaId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_MarcaId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Equipos");

            migrationBuilder.AddColumn<string>(
                name: "MarcaEquipo",
                table: "Equipos",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
