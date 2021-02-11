using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventariosEquipos.Web.Data
{
    public class SeedDB
    {
        private readonly DataContext _context;

        public SeedDB(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckColoresAsync();
            await CheckDesempeñosAsync();
            await CheckUsosAsync();
            await CheckSucursalesAsync();
            await CheckEstadosAsync();
            await CheckSistemasOperativosAsync();
            await CheckOfficeLicenciasAsync();
            await CheckLicenciasSistemasOperativosAsync();
        }

        private async Task CheckColoresAsync()
        {
            if (!_context.Colores.Any())
            {
                _context.Colores.Add(new Entities.Color {NombreColor = "Negro"});
                _context.Colores.Add(new Entities.Color { NombreColor = "Blanco" });
                _context.Colores.Add(new Entities.Color { NombreColor = "Gris" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckDesempeñosAsync()
        {
            if (!_context.Desempeños.Any())
            {
                _context.Desempeños.Add(new Entities.Desempeño { NombreDesempeño = "Alto" });
                _context.Desempeños.Add(new Entities.Desempeño { NombreDesempeño = "Medio" });
                _context.Desempeños.Add(new Entities.Desempeño { NombreDesempeño = "Bajo" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckUsosAsync()
        {
            if (!_context.Usos.Any())
            {
                _context.Usos.Add(new Entities.Uso { NombreUso = "Uso 1" });
                _context.Usos.Add(new Entities.Uso { NombreUso = "Uso 2" });
                _context.Usos.Add(new Entities.Uso { NombreUso = "Uso 3" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckSucursalesAsync()
        {
            if (!_context.Sucursales.Any())
            {
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Sucursal 1" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Sucursal 2" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Sucursal 3" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckEstadosAsync()
        {
            if (!_context.Estados.Any())
            {
                _context.Estados.Add(new Entities.Estado { NombreEstado = "Estado 1" });
                _context.Estados.Add(new Entities.Estado { NombreEstado = "Estado 2" });
                _context.Estados.Add(new Entities.Estado { NombreEstado = "Estado 3" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckSistemasOperativosAsync()
        {
            if (!_context.SistemasOperativos.Any())
            {
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Sistema operativo 1" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Sistema operativo 2" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Sistema operativo 3" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckOfficeLicenciasAsync()
        {
            if (!_context.OfficeLicencias.Any())
            {
                _context.OfficeLicencias.Add(new Entities.OfficeLicencia { LicenciaOffice = "Licencia Office 1" });
                _context.OfficeLicencias.Add(new Entities.OfficeLicencia { LicenciaOffice = "Licencia Office 2" });
                _context.OfficeLicencias.Add(new Entities.OfficeLicencia { LicenciaOffice = "Licencia Office 3" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckLicenciasSistemasOperativosAsync()
        {
            if (!_context.LicenciasSistemasOperativos.Any())
            {
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = "Licencia Sistema Operativo 1" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = "Licencia Sistema Operativo 2" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = "Licencia Sistema Operativo 3" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
