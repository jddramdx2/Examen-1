using Microsoft.EntityFrameworkCore;
using SistemaReciclaje.Models;

namespace SistemaReciclaje.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Barco> Barcos { get; set; }
        public DbSet<Operacion> Operaciones { get; set; }
        public DbSet<TipoBasura> TiposBasura { get; set; }
    }
}
