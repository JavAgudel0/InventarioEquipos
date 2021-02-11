using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventariosEquipos.Web.Data.Entities
{
    public class OfficeLicencia
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string LicenciaOffice { get; set; }
    }
}
