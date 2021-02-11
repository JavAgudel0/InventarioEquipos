using Microsoft.EntityFrameworkCore.Migrations;

namespace InventariosEquipos.Web.Migrations
{
    public partial class DesempenoCambio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Desempeños_DesempeñoId",
                table: "Equipos");

            migrationBuilder.RenameColumn(
                name: "DesempeñoId",
                table: "Equipos",
                newName: "DesempenoId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_DesempeñoId",
                table: "Equipos",
                newName: "IX_Equipos_DesempenoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Desempeños_DesempenoId",
                table: "Equipos",
                column: "DesempenoId",
                principalTable: "Desempeños",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Desempeños_DesempenoId",
                table: "Equipos");

            migrationBuilder.RenameColumn(
                name: "DesempenoId",
                table: "Equipos",
                newName: "DesempeñoId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_DesempenoId",
                table: "Equipos",
                newName: "IX_Equipos_DesempeñoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Desempeños_DesempeñoId",
                table: "Equipos",
                column: "DesempeñoId",
                principalTable: "Desempeños",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
