using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace InventariosEquipos.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboColores();

        IEnumerable<SelectListItem> GetComboMarcas();

        IEnumerable<SelectListItem> GetComboDesempenos();

        IEnumerable<SelectListItem> GetComboUsos();

        IEnumerable<SelectListItem> GetComboSucursales();

        IEnumerable<SelectListItem> GetComboEstados();

        IEnumerable<SelectListItem> GetComboSistemasOperativos();

        IEnumerable<SelectListItem> GetComboOfficeLicencias();

        IEnumerable<SelectListItem> GetComboLicenciasSistemasOperativos();

    }
}