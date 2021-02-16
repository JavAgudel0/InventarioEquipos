using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventariosEquipos.Web.Data.Entities
{
    public class Equipo
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Codigo del equipo")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Codigo de calidad")]
        public string CodigoCalidad { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        public string Referencia { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Asignado a")]
        public string EmpleadoAsignado { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Nombre completo")]
        public string NombreEmpleado { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Cargo del empleado")]
        public string CargoEmpleado { get; set; }

        //[Required(ErrorMessage = "El campo {0} es obligatorio.")]
        //[MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        //public string Sucursal { get; set; }

        public Sucursal Sucursal { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Nombre del equipo")]
        public string NombreEquipo { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Tipo de equipo")]
        public string TipoEquipo { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Direccion IP")]
        public string DireccionIP { get; set; }

        //[Required(ErrorMessage = "El campo {0} es obligatorio.")]
        //[MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        //[Display(Name = "Uso del equipo")]
        //public string UsoEquipo { get; set; }

        public Uso Uso { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Serial del equipo")]
        public string SerialEquipo { get; set; }

        //[Required(ErrorMessage = "El campo {0} es obligatorio.")]
        //[MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        //[Display(Name = "S.O instalado")]
        //public string SistemaOperativoInstalado { get; set; }

        [Display(Name = "Sistema Operativo")]
        public SistemaOperativo SistemaOperativo { get; set; }

        //[Required(ErrorMessage = "El campo {0} es obligatorio.")]
        //[MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        //[Display(Name = "Estado del equipo")]
        //public string EstadoEquipo { get; set; }

        public Estado Estado { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Disco duro")]
        public string DiscoDuro { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        public string Procesador { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        public string Ram { get; set; }

        //[Required(ErrorMessage = "El campo {0} es obligatorio.")]
        //[MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        //[Display(Name = "S.O Licencia")]
        //public string LicenciaSistemaOperativo { get; set; }

        [Display(Name = "Licencia del S.O")]
        public LicenciaSistemaOperativo LicenciaSistemaOperativo { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Licencia de Office")]
        public string LicenciaOffice { get; set; }

        //[Display(Name = "Licencia Office")]
        //public OfficeLicencia OfficeLicencia { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        public string Antivirus { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        public string Backup { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]        
        [Display(Name = "Fecha de adquisicion")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        public string FechaAdquisicion { get; set; }

        //[Required(ErrorMessage = "El campo {0} es obligatorio.")]
        //[MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        //[Display(Name = "Marca del equipo")]
        //public string MarcaEquipo { get; set; }


        public Marca Marca { get; set; }

        public Color Color { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Precio de compra")]
        public int PrecioCompra { get; set; }

        //[Required(ErrorMessage = "El campo {0} es obligatorio.")]
        //[MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        //[Display(Name = "Desempeño del PC")]
        //public string DesempeñoPC { get; set; }

        
        [Display(Name = "Desempeño")]
        public Desempeño Desempeno { get; set; }

        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "SAP IP")]
        public string SapIP { get; set; }

        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "SAP remoto")]
        public string SapRemoto { get; set; }
        
        public string Observaciones { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        //[Display(Name = "Imagen")]
        //public string Image { get; set; }        
    }


}

