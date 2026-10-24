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

        [Display(Name = "Cédula de Identidad")]
        [StringLength(10, MinimumLength = 10,
            ErrorMessage = "La cédula debe tener 10 dígitos.")]
        [RegularExpression(@"^\d{10}$",
            ErrorMessage = "Use solo números.")]
        public string CedulaIdentidad { get; set; } = string.Empty;
    }
}
