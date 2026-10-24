using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace GRUPO3.Models
{
    public class Maestro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ingrese el apellido.")]
        public string Apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ingrese la especialidad.")]
        [Display(Name = "Especialidad")]
        public string Especialidad { get; set; } = string.Empty;
    }
}
