using Microsoft.EntityFrameworkCore;
using PortafolioProyectos.Models;


namespace PortafolioProyectos.Context
{
    public class PortafolioDbContext:DbContext
    {
        public PortafolioDbContext(DbContextOptions<PortafolioDbContext> options)
        : base(options)
        {

        }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Lenguaje> Lenguajes { get; set; }
    }
}
