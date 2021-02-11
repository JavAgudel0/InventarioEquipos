using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosEquipos.Web.Data.Entities
{
    public class Color
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string NombreColor { get; set; }

        public ICollection<Equipo> Equipos { get; set; }
    }
}
