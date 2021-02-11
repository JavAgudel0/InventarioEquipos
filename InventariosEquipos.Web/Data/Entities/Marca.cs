using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosEquipos.Web.Data.Entities
{
    public class Marca
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string NombreMarca { get; set; }

        public ICollection<Equipo> Equipos { get; set; }
    }
}
