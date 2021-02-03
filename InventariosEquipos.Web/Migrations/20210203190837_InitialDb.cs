using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventariosEquipos.Web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CodigoCalidad = table.Column<string>(maxLength: 50, nullable: false),
                    Referencia = table.Column<string>(maxLength: 100, nullable: false),
                    EmpleadoAsignado = table.Column<string>(maxLength: 20, nullable: false),
                    NombreEmpleado = table.Column<string>(maxLength: 100, nullable: false),
                    CargoEmpleado = table.Column<string>(maxLength: 100, nullable: false),
                    Sucursal = table.Column<string>(maxLength: 30, nullable: false),
                    NombreEquipo = table.Column<string>(maxLength: 50, nullable: false),
                    TipoEquipo = table.Column<string>(maxLength: 50, nullable: false),
                    DireccionIP = table.Column<string>(maxLength: 20, nullable: false),
                    UsoEquipo = table.Column<string>(maxLength: 30, nullable: false),
                    SerialEquipo = table.Column<string>(maxLength: 30, nullable: false),
                    SistemaOperativoInstalado = table.Column<string>(maxLength: 50, nullable: false),
                    EstadoEquipo = table.Column<string>(maxLength: 30, nullable: false),
                    DiscoDuro = table.Column<string>(maxLength: 10, nullable: false),
                    Procesador = table.Column<string>(maxLength: 100, nullable: false),
                    Ram = table.Column<string>(maxLength: 10, nullable: false),
                    LicenciaSistemaOperativo = table.Column<string>(maxLength: 100, nullable: false),
                    LicenciaOffice = table.Column<string>(maxLength: 100, nullable: false),
                    Antivirus = table.Column<string>(maxLength: 50, nullable: false),
                    Backup = table.Column<string>(maxLength: 100, nullable: true),
                    FechaAdquisicion = table.Column<DateTime>(nullable: false),
                    MarcaEquipo = table.Column<string>(maxLength: 50, nullable: false),
                    Color = table.Column<string>(maxLength: 20, nullable: false),
                    PrecioCompra = table.Column<int>(maxLength: 15, nullable: false),
                    DesempeñoPC = table.Column<string>(maxLength: 20, nullable: false),
                    SapIP = table.Column<string>(maxLength: 20, nullable: true),
                    SapRemoto = table.Column<string>(maxLength: 20, nullable: true),
                    Observaciones = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipos");
        }
    }
}
