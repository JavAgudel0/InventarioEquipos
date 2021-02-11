using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosEquipos.Web.Data.Entities
{
    public class Sucursal
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string NombreSucursal { get; set; }

        public ICollection<Equipo> Equipos { get; set; }

    }
}
