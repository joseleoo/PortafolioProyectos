using Microsoft.EntityFrameworkCore;
using PortafolioProyectos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Thinktecture;

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

            base.OnModelCreating(modelBuilder);
            //Random rnd = new Random();
            //int cantRandom = rnd.Next(10, 20);
            //var clientes = GenerarClientesAlAzar(cantRandom);
            var clientes = new List<Cliente> {
            new Cliente { Id=1,Nombre="Jose Leonardo",Apellido="Quiñones",Email="desarrollojlq@aoutlook.es",Telefono="316 898 2961"},
            new Cliente { Id=2,Nombre="Saidy",Apellido="Losada",Email="slosada6@misena.edu.co",Telefono="316 000 2961"},
            new Cliente { Id=3,Nombre="Juan Carlos",Apellido="Pajaro",Email="pajaro@misena.edu.co",Telefono="000 898 2961"},

            };
            var estados = new List<Estado> {
                new Estado{ Id=1,Descripcion="EN NEGOCIACION"} ,
                new Estado{ Id=2,Descripcion="EN PROCESO"} ,
                new Estado{ Id=3,Descripcion="TERMINADO"} ,
                new Estado{ Id=4,Descripcion="aNULADO"}
            };

            var proyectos = new List<Proyecto> {
                new Proyecto{Id=1,Descripcion="Leon Software",ClienteId=1,EstadoId=1,FechaInicio=DateTime.Now,FechaFin=DateTime.Now.AddDays(20),Horas=40,Precio=200000},
                new Proyecto{Id=2,Descripcion="Riesgos",ClienteId=2,EstadoId=2,FechaInicio=DateTime.Now,FechaFin=DateTime.Now.AddDays(10),Horas=35,Precio=205000}
            };

            modelBuilder.Entity<Estado>().HasData(estados.ToArray());
            modelBuilder.Entity<Cliente>().HasData(clientes.ToArray());
            modelBuilder.Entity<Proyecto>().HasData(proyectos.ToArray());

        }

    }
}
