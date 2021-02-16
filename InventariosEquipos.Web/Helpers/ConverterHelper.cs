using InventariosEquipos.Web.Data;
using InventariosEquipos.Web.Data.Entities;
using InventariosEquipos.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventariosEquipos.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        private readonly DataContext _datacontext;
        private readonly ICombosHelper _comboshelper;

        public ConverterHelper(DataContext datacontext, ICombosHelper combosHelper)
        {
            _datacontext = datacontext;
            _comboshelper = combosHelper;
        }

        public async Task<Equipo> ToEquipoAsync(EquipoViewModel model, string path)
        {
            var equipo = new Equipo
            {
                Id = model.Id,
                CodigoCalidad = model.CodigoCalidad,
                Referencia = model.Referencia,
                EmpleadoAsignado = model.EmpleadoAsignado,
                NombreEmpleado = model.NombreEmpleado,
                CargoEmpleado = model.CargoEmpleado,
                Sucursal = await _datacontext.Sucursales.FindAsync(model.SucursalId),
                NombreEquipo = model.NombreEquipo,
                TipoEquipo = model.TipoEquipo,
                DireccionIP = model.DireccionIP,
                Uso = await _datacontext.Usos.FindAsync(model.UsoID),
                SerialEquipo = model.SerialEquipo,
                SistemaOperativo = await _datacontext.SistemasOperativos.FindAsync(model.SistemaOperativoId),
                Estado = await _datacontext.Estados.FindAsync(model.EstadoId),
                DiscoDuro = model.DiscoDuro,
                Procesador = model.Procesador,
                Ram = model.Ram,
                LicenciaSistemaOperativo = await _datacontext.LicenciasSistemasOperativos.FindAsync(model.LicenciaSistemaOperativoId),
                LicenciaOffice = model.LicenciaOffice,
                Antivirus = model.Antivirus,
                Backup = model.Backup,
                FechaAdquisicion = model.FechaAdquisicion,
                Marca = await _datacontext.Marcas.FindAsync(model.MarcaId),
                Color = await _datacontext.Colores.FindAsync(model.ColorId),
                PrecioCompra = model.PrecioCompra,
                Desempeno = await _datacontext.Desempeños.FindAsync(model.DesempenoId),
                SapIP = model.SapIP,
                SapRemoto = model.SapRemoto,
                Observaciones = model.Observaciones,
                ImageUrl = path
            };
            return equipo;
        }

        public EquipoViewModel ToEquipoViewModel (Equipo equipo){
            return new EquipoViewModel
            {
                Id = equipo.Id,
                CodigoCalidad = equipo.CodigoCalidad,
                Referencia = equipo.Referencia,
                EmpleadoAsignado = equipo.EmpleadoAsignado,
                NombreEmpleado = equipo.NombreEmpleado,
                CargoEmpleado = equipo.CargoEmpleado,
                SucursalId = equipo.Sucursal.Id,
                Sucursales = _comboshelper.GetComboSucursales(),
                NombreEquipo = equipo.NombreEquipo,
                TipoEquipo = equipo.TipoEquipo,
                DireccionIP = equipo.DireccionIP,
                UsoID = equipo.Uso.Id,
                Usos = _comboshelper.GetComboUsos(),
                SerialEquipo = equipo.SerialEquipo,
                SistemaOperativoId = equipo.SistemaOperativo.Id,
                SistemasOperativos = _comboshelper.GetComboSistemasOperativos(),
                EstadoId = equipo.Estado.Id,
                Estados = _comboshelper.GetComboEstados(),
                DiscoDuro = equipo.DiscoDuro,
                Procesador = equipo.Procesador,
                Ram = equipo.Ram,
                LicenciaSistemaOperativoId = equipo.LicenciaSistemaOperativo.Id,
                LicenciasSistemasOperativos = _comboshelper.GetComboLicenciasSistemasOperativos(),
                LicenciaOffice = equipo.LicenciaOffice,
                Antivirus = equipo.Antivirus,
                Backup = equipo.Backup,
                FechaAdquisicion = equipo.FechaAdquisicion,
                MarcaId = equipo.Marca.Id,
                Marcas = _comboshelper.GetComboMarcas(),
                ColorId = equipo.Color.Id,
                Colores = _comboshelper.GetComboColores(),
                PrecioCompra = equipo.PrecioCompra,
                DesempenoId = equipo.Desempeno.Id,
                Desempenos = _comboshelper.GetComboDesempenos(),
                SapIP = equipo.SapIP,
                SapRemoto = equipo.SapRemoto,
                Observaciones = equipo.Observaciones,
                ImageUrl = equipo.ImageUrl
               
            };
        }
    }
}
