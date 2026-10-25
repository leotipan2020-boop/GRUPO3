
namespace GRUPO3.Models
{
    public class Asignatura
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Codigo { get; set; } = string.Empty;

        public int HorasSemanales { get; set; }
    }
}
