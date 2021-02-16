using Microsoft.EntityFrameworkCore.Migrations;

namespace InventariosEquipos.Web.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_OfficeLicencias_OfficeLicenciaId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_OfficeLicenciaId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "OfficeLicenciaId",
                table: "Equipos");

            migrationBuilder.AddColumn<string>(
                name: "LicenciaOffice",
                table: "Equipos",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicenciaOffice",
                table: "Equipos");

            migrationBuilder.AddColumn<int>(
                name: "OfficeLicenciaId",
                table: "Equipos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_OfficeLicenciaId",
                table: "Equipos",
                column: "OfficeLicenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_OfficeLicencias_OfficeLicenciaId",
                table: "Equipos",
                column: "OfficeLicenciaId",
                principalTable: "OfficeLicencias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
