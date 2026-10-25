
using GRUPO3.Models;
using Microsoft.EntityFrameworkCore;

namespace GRUPO3.Data
{
    public class EscolarContext : DbContext
    {
        public EscolarContext(
            DbContextOptions<EscolarContext> options)
            : base(options)
        {
        }

        public DbSet<Aula> Aulas { get; set; } = null!;

        public DbSet<Estudiante> Estudiantes { get; set; } = null!;

        public DbSet<Maestro> Maestros { get; set; } = null!;

        public DbSet<Libro> Libros { get; set; } = null!;

        public DbSet<Asignatura> Asignaturas { get; set; } = null!;
    }
}
