using Microsoft.EntityFrameworkCore.Migrations;

namespace InventariosEquipos.Web.Migrations
{
    public partial class Desempeño : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DesempeñoPC",
                table: "Equipos");

            migrationBuilder.AddColumn<int>(
                name: "DesempeñoId",
                table: "Equipos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_DesempeñoId",
                table: "Equipos",
                column: "DesempeñoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Desempeños_DesempeñoId",
                table: "Equipos",
                column: "DesempeñoId",
                principalTable: "Desempeños",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Desempeños_DesempeñoId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_DesempeñoId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "DesempeñoId",
                table: "Equipos");

            migrationBuilder.AddColumn<string>(
                name: "DesempeñoPC",
                table: "Equipos",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
