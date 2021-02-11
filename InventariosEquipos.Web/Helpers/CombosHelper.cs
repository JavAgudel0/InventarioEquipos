using InventariosEquipos.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace InventariosEquipos.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;

        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboColores()
        {

            var list = _dataContext.Colores.Select(pt => new SelectListItem
            {
                Text = pt.NombreColor,
                Value = $"{pt.Id}"

            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un color...]",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboMarcas()
        {

            var list1 = _dataContext.Marcas.Select(pt => new SelectListItem
            {
                Text = pt.NombreMarca,
                Value = $"{pt.Id}"

            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list1.Insert(0, new SelectListItem
            {
                Text = "[Seleccione una marca...]",
                Value = "0"
            });

            return list1;
        }

        public IEnumerable<SelectListItem> GetComboDesempenos()
        {

            var list2 = _dataContext.Desempeños.Select(pt => new SelectListItem
            {
                Text = pt.NombreDesempeño,
                Value = $"{pt.Id}"

            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list2.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un desempeño...]",
                Value = "0"
            });

            return list2;
        }

        public IEnumerable<SelectListItem> GetComboUsos()
        {

            var list3 = _dataContext.Usos.Select(pt => new SelectListItem
            {
                Text = pt.NombreUso,
                Value = $"{pt.Id}"

            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list3.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un uso...]",
                Value = "0"
            });

            return list3;
        }

        public IEnumerable<SelectListItem> GetComboSucursales()
        {

            var list4 = _dataContext.Sucursales.Select(pt => new SelectListItem
            {
                Text = pt.NombreSucursal,
                Value = $"{pt.Id}"

            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list4.Insert(0, new SelectListItem
            {
                Text = "[Seleccione una sucursal...]",
                Value = "0"
            });

            return list4;
        }

        public IEnumerable<SelectListItem> GetComboEstados()
        {

            var list5 = _dataContext.Estados.Select(pt => new SelectListItem
            {
                Text = pt.NombreEstado,
                Value = $"{pt.Id}"

            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list5.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un estado...]",
                Value = "0"
            });

            return list5;
        }

        public IEnumerable<SelectListItem> GetComboSistemasOperativos()
        {

            var list6 = _dataContext.SistemasOperativos.Select(pt => new SelectListItem
            {
                Text = pt.NombreSistemaOperativo,
                Value = $"{pt.Id}"

            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list6.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un sistema operativo...]",
                Value = "0"
            });

            return list6;
        }

        public IEnumerable<SelectListItem> GetComboOfficeLicencias()
        {

            var list7 = _dataContext.OfficeLicencias.Select(pt => new SelectListItem
            {
                Text = pt.LicenciaOffice,
                Value = $"{pt.Id}"

            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list7.Insert(0, new SelectListItem
            {
                Text = "[Seleccione una licencia de Office...]",
                Value = "0"
            });

            return list7;
        }

        public IEnumerable<SelectListItem> GetComboLicenciasSistemasOperativos()
        {

            var list8 = _dataContext.LicenciasSistemasOperativos.Select(pt => new SelectListItem
            {
                Text = pt.Licencia,
                Value = $"{pt.Id}"

            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list8.Insert(0, new SelectListItem
            {
                Text = "[Seleccione una licencia de Office...]",
                Value = "0"
            });

            return list8;
        }
    }
}
