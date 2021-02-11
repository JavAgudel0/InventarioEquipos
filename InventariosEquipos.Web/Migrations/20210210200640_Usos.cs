using Microsoft.EntityFrameworkCore.Migrations;

namespace InventariosEquipos.Web.Migrations
{
    public partial class Usos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsoEquipo",
                table: "Equipos");

            migrationBuilder.AddColumn<int>(
                name: "UsoId",
                table: "Equipos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_UsoId",
                table: "Equipos",
                column: "UsoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Usos_UsoId",
                table: "Equipos",
                column: "UsoId",
                principalTable: "Usos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Usos_UsoId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_UsoId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "UsoId",
                table: "Equipos");

            migrationBuilder.AddColumn<string>(
                name: "UsoEquipo",
                table: "Equipos",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }
    }
}
