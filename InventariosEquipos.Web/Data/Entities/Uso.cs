using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosEquipos.Web.Data.Entities
{
    public class Uso
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string NombreUso { get; set; }

        public ICollection<Equipo> Equipos { get; set; }
    }
}
