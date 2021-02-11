using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosEquipos.Web.Data.Entities
{
    public class Desempeño
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string NombreDesempeño { get; set; }

        public ICollection<Equipo> Equipos { get; set; }
    }
}
