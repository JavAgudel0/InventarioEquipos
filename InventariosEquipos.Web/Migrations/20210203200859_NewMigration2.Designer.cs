﻿// <auto-generated />
using System;
using InventariosEquipos.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventariosEquipos.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210203200859_NewMigration2")]
    partial class NewMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventariosEquipos.Web.Data.Entities.Equipo", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Antivirus")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Backup")
                        .HasMaxLength(100);

                    b.Property<string>("CargoEmpleado")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CodigoCalidad")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("DesempeñoPC")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("DireccionIP")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("DiscoDuro")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("EmpleadoAsignado")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("EstadoEquipo")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("FechaAdquisicion");

                    b.Property<string>("LicenciaOffice")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LicenciaSistemaOperativo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("MarcaEquipo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NombreEmpleado")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NombreEquipo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Observaciones")
                        .HasMaxLength(500);

                    b.Property<int>("PrecioCompra")
                        .HasMaxLength(15);

                    b.Property<string>("Procesador")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Ram")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("SapIP")
                        .HasMaxLength(20);

                    b.Property<string>("SapRemoto")
                        .HasMaxLength(20);

                    b.Property<string>("SerialEquipo")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("SistemaOperativoInstalado")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sucursal")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("TipoEquipo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UsoEquipo")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Equipos");
                });
#pragma warning restore 612, 618
        }
    }
}
