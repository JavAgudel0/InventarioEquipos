using InventariosEquipos.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventariosEquipos.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Color> Colores { get; set; }
        public DbSet<Desempeño> Desempeños { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<LicenciaSistemaOperativo> LicenciasSistemasOperativos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<SistemaOperativo> SistemasOperativos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Uso> Usos { get; set; }
    }
}
