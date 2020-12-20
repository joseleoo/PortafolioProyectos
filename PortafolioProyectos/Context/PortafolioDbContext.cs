using Microsoft.EntityFrameworkCore;
using PortafolioProyectos.Models;


namespace PortafolioProyectos.Context
{
    public class PortafolioDbContext : DbContext
    {
        public PortafolioDbContext(DbContextOptions<PortafolioDbContext> options)
        : base(options)
        {

        }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Lenguaje> Lenguajes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<LenguajesPorProyecto> LenguajesPorProyectos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LenguajesPorProyecto>()
                .HasKey(lp => new { lp.LenguajeId, lp.ProyectoId });
          
    
        }
    }
}
