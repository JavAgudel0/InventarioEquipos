using InventariosEquipos.Web.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventariosEquipos.Web.Models
{
    public class EquipoViewModel : Equipo
    {
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Color")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un color.")]
        public int ColorId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Marca")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar una marca.")]
        public int MarcaId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Desempeño")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un desempeño.")]
        public int DesempenoId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Uso")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un uso.")]
        public int UsoID { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Sucursal")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar una sucursal.")]
        public int SucursalId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Estado")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un estado.")]
        public int EstadoId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Sistema Operativo")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un sistema operativo.")]
        public int SistemaOperativoId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Licencia de office")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar una licencia de office.")]
        public int OfficeLicenciaId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Licencia Sistema Operativo")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar una licencia de office.")]
        public int LicenciaSistemaOperativoId { get; set; }

        public IEnumerable<SelectListItem> Colores { get; set; }

        public IEnumerable<SelectListItem> Marcas { get; set; }

        public IEnumerable<SelectListItem> Desempenos { get; set; }

        public IEnumerable<SelectListItem> Usos { get; set; }

        public IEnumerable<SelectListItem> Sucursales { get; set; }

        public IEnumerable<SelectListItem> Estados { get; set; }

        public IEnumerable<SelectListItem> SistemasOperativos { get; set; }

        public IEnumerable<SelectListItem> OfficeLicencias { get; set; }

        public IEnumerable<SelectListItem> LicenciasSistemasOperativos { get; set; }
    }
}
