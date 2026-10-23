using System.ComponentModel.DataAnnotations;

namespace GRUPO3.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;

        [Display(Name = "Cédula de Identidad")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "La cédula debe tener 10 dígitos.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Use solo números.")]
        public string CedulaIdentidad { get; set; } = string.Empty;
    }
}