using InventariosEquipos.Web.Data.Entities;
using InventariosEquipos.Web.Models;
using System.Threading.Tasks;

namespace InventariosEquipos.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Equipo> ToEquipoAsync(EquipoViewModel model, string path);

        EquipoViewModel ToEquipoViewModel(Equipo equipo);
    }
}