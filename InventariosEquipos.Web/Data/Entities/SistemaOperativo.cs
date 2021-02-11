using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosEquipos.Web.Data.Entities
{
    public class SistemaOperativo
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public string NombreSistemaOperativo { get; set; }

        public ICollection<Equipo> Equipos { get; set; }
    }
}
