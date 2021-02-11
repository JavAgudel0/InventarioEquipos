using Microsoft.EntityFrameworkCore.Migrations;

namespace InventariosEquipos.Web.Migrations
{
    public partial class SisOperYSisOperYOffiLicen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicenciaOffice",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "LicenciaSistemaOperativo",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "SistemaOperativoInstalado",
                table: "Equipos");

            migrationBuilder.AddColumn<int>(
                name: "LicenciaSistemaOperativoId",
                table: "Equipos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OfficeLicenciaId",
                table: "Equipos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SistemaOperativoId",
                table: "Equipos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_LicenciaSistemaOperativoId",
                table: "Equipos",
                column: "LicenciaSistemaOperativoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_OfficeLicenciaId",
                table: "Equipos",
                column: "OfficeLicenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_SistemaOperativoId",
                table: "Equipos",
                column: "SistemaOperativoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_LicenciasSistemasOperativos_LicenciaSistemaOperativoId",
                table: "Equipos",
                column: "LicenciaSistemaOperativoId",
                principalTable: "LicenciasSistemasOperativos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_OfficeLicencias_OfficeLicenciaId",
                table: "Equipos",
                column: "OfficeLicenciaId",
                principalTable: "OfficeLicencias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_SistemasOperativos_SistemaOperativoId",
                table: "Equipos",
                column: "SistemaOperativoId",
                principalTable: "SistemasOperativos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_LicenciasSistemasOperativos_LicenciaSistemaOperativoId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_OfficeLicencias_OfficeLicenciaId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_SistemasOperativos_SistemaOperativoId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_LicenciaSistemaOperativoId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_OfficeLicenciaId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_SistemaOperativoId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "LicenciaSistemaOperativoId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "OfficeLicenciaId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "SistemaOperativoId",
                table: "Equipos");

            migrationBuilder.AddColumn<string>(
                name: "LicenciaOffice",
                table: "Equipos",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LicenciaSistemaOperativo",
                table: "Equipos",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SistemaOperativoInstalado",
                table: "Equipos",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
