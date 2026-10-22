namespace GRUPO3.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public string Numero { get; set; } = string.Empty;
        public int Capacidad { get; set; }
        public string Ubicacion { get; set; } = string.Empty;
    }
}