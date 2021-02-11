using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventariosEquipos.Web.Data.Entities
{
    public class Estado        
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string NombreEstado { get; set; }
    }
}
