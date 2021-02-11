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
    [Migration("20210210142804_Marca")]
    partial class Marca
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventariosEquipos.Web.Data.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreColor")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Colores");
                });

            modelBuilder.Entity("InventariosEquipos.Web.Data.Entities.Desempeño", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreDesempeño")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Desempeños");
                });

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

                    b.Property<int?>("ColorId");

                    b.Property<string>("DesempeñoPC")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("DireccionIP")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("DiscoDuro")
                        .IsRequired()
                        .HasMaxLength(20);

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

                    b.Property<int?>("MarcaId");

                    b.Property<string>("NombreEmpleado")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NombreEquipo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Observaciones")
                        .HasMaxLength(500);

                    b.Property<int>("PrecioCompra");

                    b.Property<string>("Procesador")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Ram")
                        .IsRequired()
                        .HasMaxLength(20);

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

                    b.HasIndex("ColorId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("InventariosEquipos.Web.Data.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreEstado")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("InventariosEquipos.Web.Data.Entities.LicenciaSistemaOperativo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Licencia")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("LicenciasSistemasOperativos");
                });

            modelBuilder.Entity("InventariosEquipos.Web.Data.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreMarca")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("InventariosEquipos.Web.Data.Entities.OfficeLicencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LicenciaOffice")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("OfficeLicencias");
                });

            modelBuilder.Entity("InventariosEquipos.Web.Data.Entities.SistemaOperativo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreSistemaOperativo")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("SistemasOperativos");
                });

            modelBuilder.Entity("InventariosEquipos.Web.Data.Entities.Sucursal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreSucursal")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("InventariosEquipos.Web.Data.Entities.Uso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreUso")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Usos");
                });

            modelBuilder.Entity("InventariosEquipos.Web.Data.Entities.Equipo", b =>
                {
                    b.HasOne("InventariosEquipos.Web.Data.Entities.Color", "Color")
                        .WithMany("Equipos")
                        .HasForeignKey("ColorId");

                    b.HasOne("InventariosEquipos.Web.Data.Entities.Marca", "Marca")
                        .WithMany("Equipos")
                        .HasForeignKey("MarcaId");
                });
#pragma warning restore 612, 618
        }
    }
}
