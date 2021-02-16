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
            await CheckLicenciasSistemasOperativosAsync();
            await CheckMarcasAsync();
        }

        private async Task CheckColoresAsync()
        {
            if (!_context.Colores.Any())
            {
                _context.Colores.Add(new Entities.Color {NombreColor = "Amarillo"});
                _context.Colores.Add(new Entities.Color { NombreColor = "Azul" });
                _context.Colores.Add(new Entities.Color { NombreColor = "Blanco" });
                _context.Colores.Add(new Entities.Color { NombreColor = "Gris" });
                _context.Colores.Add(new Entities.Color { NombreColor = "Naranja" });
                _context.Colores.Add(new Entities.Color { NombreColor = "Rojo" });
                _context.Colores.Add(new Entities.Color { NombreColor = "Rosado" });
                _context.Colores.Add(new Entities.Color { NombreColor = "Negro" });

                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckDesempeñosAsync()
        {
            if (!_context.Desempeños.Any())
            {
                _context.Desempeños.Add(new Entities.Desempeño { NombreDesempeño = "Alto" });
                _context.Desempeños.Add(new Entities.Desempeño { NombreDesempeño = "Bajo" });
                _context.Desempeños.Add(new Entities.Desempeño { NombreDesempeño = "Medio" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckUsosAsync()
        {
            if (!_context.Usos.Any())
            {
                _context.Usos.Add(new Entities.Uso { NombreUso = "Empresa" });
                _context.Usos.Add(new Entities.Uso { NombreUso = "Personal" });
                _context.Usos.Add(new Entities.Uso { NombreUso = "Proovedor de servivios" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckSucursalesAsync()
        {
            if (!_context.Sucursales.Any())
            {
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Cb3" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Electroindustrial" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Electrotelefonico" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Eurocircuitos" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Ie Cali" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Ie Cartagena" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Ie Ibague" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Ie Manizales" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Ie Mosquera" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "IT Neiva" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Ilumiredes" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Lumielectricos-B" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Lumielectricos-V" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Nqs" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Pretolsa" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Tamana" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Cointelco" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Ie Monteria" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Ie Cucuta" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Contemos" });
                _context.Sucursales.Add(new Entities.Sucursal { NombreSucursal = "Universo Electrico" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckEstadosAsync()
        {
            if (!_context.Estados.Any())
            {
                _context.Estados.Add(new Entities.Estado { NombreEstado = "Activo" });
                _context.Estados.Add(new Entities.Estado { NombreEstado = "Borrar - Duplicado" });
                _context.Estados.Add(new Entities.Estado { NombreEstado = "Borrar - Retirado" });
                _context.Estados.Add(new Entities.Estado { NombreEstado = "Dado de baja" });
                _context.Estados.Add(new Entities.Estado { NombreEstado = "Dañado" });
                _context.Estados.Add(new Entities.Estado { NombreEstado = "Disponible" });                
                
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckSistemasOperativosAsync()
        {
            if (!_context.SistemasOperativos.Any())
            {
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Ninguno" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux CentOS" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux OS" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux Debian" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux Fedora" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux Fuduntu" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux Gentoo" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux Knoppix" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux Kubuntu" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux Mandriva" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux openSUSE" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux Red Hat Enterprise Linux" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux Ubuntu" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Linux Zorin OS" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X 10 Cheetah" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X 10.1 Puma" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X 10.1 Yosemite" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X 10.11 El Capitan" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X 10.2 Jaguar" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X 10.3 Panther" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X 10.4 Tiger" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X 10.5 Leopard" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X 10.6 Snow Leopard" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X 10.7 Lion" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X 10.8 Mountain Lion" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X 10.9 Mavericks" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X Beta p" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Mac OS X Mac OS X Server 1.0 Hera" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Vmware" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 10" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 10 Educacion" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 10 Enterprise" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 10 Home" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 10 Home Single Language" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 10 Pro" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 10 Single Language" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 7 Enterprise" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 7 Home Basic" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 7 Home Premium" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 7 Profesional" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 7 Starter" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 7 Ultimate" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 8" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 8 Enterprise" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 8 Pro" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 8 Single Language" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 8.1" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 8.1 Enterprise" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 8.1 Pro" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows 8.1 Single Language" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2003 Datacenter Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2003 Enterprise Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2003 SmallBusiness Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2003 Standard Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2003 Web Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2003 R2 Datacenter Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2003 R2 Enterprise Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2003 R2 SmallBusiness Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2003 R2 Standard Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2003 R2 Web Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2008 Fundation" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2008 Web" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2008 Standard" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2008 Enterprise" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2008 Datacenter" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2008 Itanium" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2008 R2 Fundation" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2008 R2 Web" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2008 R2 Standard" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2008 R2 Enterprise" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2008 R2 Datacenter" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2008 R2 Itanium" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2012 Datacenter" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2012 Essentials" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2012 Foundation" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2012 Standard " });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2012 R2 Datacenter" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2012 R2 Essentials" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2012 R2 Foundation" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Server 2012 R2 Standard" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Storage Server 2008" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Vista Business" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Vista Enterprise" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Vista Home Basic" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Vista Home Premium" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Vista Starter" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows Vista Ultimate" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows XP 64 Bit Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows XP Corporate Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows XP Home" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows XP Media Center Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows XP Profesional" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows XP Starter Edition" });
                _context.SistemasOperativos.Add(new Entities.SistemaOperativo { NombreSistemaOperativo = "Windows XP Tablet PC Edition" });


                await _context.SaveChangesAsync();
            }
        }

        //private async Task CheckOfficeLicenciasAsync()
        //{
        //    if (!_context.OfficeLicencias.Any())
        //    {
        //        _context.OfficeLicencias.Add(new Entities.OfficeLicencia { LicenciaOffice = "Licencia Office 1" });
        //        _context.OfficeLicencias.Add(new Entities.OfficeLicencia { LicenciaOffice = "Licencia Office 2" });
        //        _context.OfficeLicencias.Add(new Entities.OfficeLicencia { LicenciaOffice = "Licencia Office 3" });
        //        await _context.SaveChangesAsync();
        //    }
        //}

        private async Task CheckLicenciasSistemasOperativosAsync()
        {
            if (!_context.LicenciasSistemasOperativos.Any())
            {
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = "OEM-Windows 10 Pro" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " Sin Licencia - Si Necesita licencia" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " Sin Licencia - NO se Necesita Licencia " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " GLP - Linux " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " MAC OS " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VMWARE " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2003 Datacenter Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2003 Enterprise Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2003 R2 Datacenter Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2003 R2 Enterprise Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2003 R2 SmallBusiness Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2003 R2 Standard Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2003 R2 Web Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2003 SmallBusiness Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2003 Standard Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2003 Web Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2008 Datacenter " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2008 Enterprise " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2008 Fundation " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2008 Itanium " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2008 R2 Datacenter" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2008 R2 Enterprise" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2008 R2 Fundation" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2008 R2 Itanium" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2008 R2 Standard" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2008 R2 Web" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2008 Standard " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2008 Web " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2012 Datacenter " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2012 Essentials " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2012 Foundation " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2012 R2 Datacenter" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2012 R2 Essentials" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2012 R2 Foundation" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2012 R2 Standard" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " FPP - Windows Server 2012 Standard " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 10 " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 10 Home " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 10 Home Single Language " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 10 Pro " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 10 Single Language" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 7 Home Basic" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 7 Home Premium" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 7 Profesional " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 7 Starter " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Pro " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 8 " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 8 Pro " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 8 Single Language" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 8.1 " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 8.1 Pro " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows 8.1 Single Language" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2003 Datacenter Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2003 Enterprise Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2003 R2 Datacenter Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2003 R2 Enterprise Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2003 R2 SmallBusiness Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2003 R2 Standard Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2003 R2 Web Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2003 SmallBusiness Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2003 Standard Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2003 Web Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2008 Datacenter " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2008 Enterprise " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2008 Fundation " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2008 Itanium " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2008 R2 Datacenter" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2008 R2 Enterprise" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2008 R2 Fundation" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2008 R2 Itanium" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2008 R2 Standard" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2008 R2 Web" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2008 Standard " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2008 Web " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2012 Datacenter " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2012 Essentials " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2012 Foundation " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2012 R2 Datacenter" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2012 R2 Essentials" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2012 R2 Foundation" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2012 R2 Standard" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Server 2012 Standard " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Vista Home Basic " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Vista Home Premium " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Vista Starter" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Vista Ultimate" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows Vista Business" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows XP 64 Bit Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows XP Corporate Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows XP Home" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows XP Media Center Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows XP Profesional" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows XP Starter Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " OEM - Windows XP Tablet PC Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows 10 Educacion " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows 10 Enterprise " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows 10 Pro " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows 7 Enterprise " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows 7 Profesional " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows 8 Enterprise " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows 8 Pro " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows 8.1 Enterprise " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows 8.1 Pro " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2003 Datacenter Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2003 Enterprise Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2003 R2 Datacenter Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2003 R2 Enterprise Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2003 R2 SmallBusiness Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2003 R2 Standard Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2003 R2 Web Edition " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2003 SmallBusiness Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2003 Standard Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2003 Web Edition" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2008 Datacenter " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2008 Enterprise " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2008 Fundation " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2008 Itanium " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2008 R2 Datacenter" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2008 R2 Enterprise" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2008 R2 Fundation" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2008 R2 Itanium" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2008 R2 Standard" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2008 R2 Web" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2008 Standard " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2008 Web " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2012 Datacenter " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2012 Essentials " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2012 Foundation " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2012 R2 Datacenter" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2012 R2 Essentials" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2012 R2 Foundation" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2012 R2 Standard" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Server 2012 Standard " });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Vista Business" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows Vista Enterprise" });
                _context.LicenciasSistemasOperativos.Add(new Entities.LicenciaSistemaOperativo { Licencia = " VLS - Windows XP Profesional" });
                
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckMarcasAsync()
        {
            if (!_context.Marcas.Any())
            { 
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Hp" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Xts" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Lantek Ii" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Buffalo" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Generico" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Western Digital" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Fonax" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Acer" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Huawei" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Cisco" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Trendnet" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Linksys" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Dinstar" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Emc" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Cybertronpc" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Dell" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Ibm" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "3com" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Apc" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Tripp Lite" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Grandstream" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Sony" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Mac" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Epson" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Lenovo" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Kyocera" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Toshiba" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Compaq" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Canon" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Gateway" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Tp - link" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Asus" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Mikrotik" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Claro" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Zte" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "CTC" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Nicomar" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Samsung" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "hEX" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Pc Smart" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Ubiquiti" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "D-link" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Argom" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Netgear" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Thermaltake" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Compumax" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Delux" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Ricoh" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Zebra" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Dymo" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Access Point" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Polycom" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Panasonic" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Modasa" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Check Writer" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Super Power" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Easy" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "M.i." });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Fujitsu" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Raisecom" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "American Sound" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Chase" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Tech" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Lexmark" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Yamaha" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Fermax" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Lsv" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Arris" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Sharp" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Telmex" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Qpcom" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Supertone" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Axis" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "TPlink" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "QUEST" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Titan" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Ablerex" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "3M" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "POWEST TITAN" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Grandestream" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "FORTINET" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "GAOKE-CLARO" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "ZTE - CLARO" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "JANUS" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "Anviz" });
            _context.Marcas.Add(new Entities.Marca { NombreMarca = "IPC" });

            await _context.SaveChangesAsync();
            
            }
        }

    }
}
