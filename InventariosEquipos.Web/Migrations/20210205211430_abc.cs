using Microsoft.EntityFrameworkCore.Migrations;

namespace InventariosEquipos.Web.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Equipos");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Equipos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_ColorId",
                table: "Equipos",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Colores_ColorId",
                table: "Equipos",
                column: "ColorId",
                principalTable: "Colores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Colores_ColorId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_ColorId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Equipos");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Equipos",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
