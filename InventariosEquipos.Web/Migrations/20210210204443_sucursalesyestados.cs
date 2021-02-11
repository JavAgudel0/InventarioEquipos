using Microsoft.EntityFrameworkCore.Migrations;

namespace InventariosEquipos.Web.Migrations
{
    public partial class sucursalesyestados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoEquipo",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "Sucursal",
                table: "Equipos");

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "Equipos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SucursalId",
                table: "Equipos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_EstadoId",
                table: "Equipos",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_SucursalId",
                table: "Equipos",
                column: "SucursalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Estados_EstadoId",
                table: "Equipos",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Sucursales_SucursalId",
                table: "Equipos",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Estados_EstadoId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Sucursales_SucursalId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_EstadoId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_SucursalId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "SucursalId",
                table: "Equipos");

            migrationBuilder.AddColumn<string>(
                name: "EstadoEquipo",
                table: "Equipos",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sucursal",
                table: "Equipos",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }
    }
}
