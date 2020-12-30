﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortafolioProyectos.Context;

namespace PortafolioProyectos.Migrations
{
    [DbContext(typeof(PortafolioDbContext))]
    [Migration("20201230015438_seedProyectos")]
    partial class seedProyectos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PortafolioProyectos.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Quiñones",
                            Email = "desarrollojlq@aoutlook.es",
                            Nombre = "Jose Leonardo",
                            Telefono = "316 898 2961"
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Losada",
                            Email = "slosada6@misena.edu.co",
                            Nombre = "Saidy",
                            Telefono = "316 000 2961"
                        },
                        new
                        {
                            Id = 3,
                            Apellido = "Pajaro",
                            Email = "pajaro@misena.edu.co",
                            Nombre = "Juan Carlos",
                            Telefono = "000 898 2961"
                        });
                });

            modelBuilder.Entity("PortafolioProyectos.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Estados");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "EN NEGOCIACION"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "EN PROCESO"
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "TERMINADO"
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "aNULADO"
                        });
                });

            modelBuilder.Entity("PortafolioProyectos.Models.Lenguaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Lenguajes");
                });

            modelBuilder.Entity("PortafolioProyectos.Models.LenguajesPorProyecto", b =>
                {
                    b.Property<int>("LenguajeId")
                        .HasColumnType("int");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nivel")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.HasKey("LenguajeId", "ProyectoId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("LenguajesPorProyectos");
                });

            modelBuilder.Entity("PortafolioProyectos.Models.Proyecto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Horas")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Proyectos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 1,
                            Descripcion = "Leon Software",
                            EstadoId = 1,
                            FechaFin = new DateTime(2021, 1, 18, 20, 54, 37, 341, DateTimeKind.Local).AddTicks(8351),
                            FechaInicio = new DateTime(2020, 12, 29, 20, 54, 37, 339, DateTimeKind.Local).AddTicks(9480),
                            Horas = 40,
                            Precio = 200000.0
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 2,
                            Descripcion = "Riesgos",
                            EstadoId = 2,
                            FechaFin = new DateTime(2021, 1, 8, 20, 54, 37, 342, DateTimeKind.Local).AddTicks(2153),
                            FechaInicio = new DateTime(2020, 12, 29, 20, 54, 37, 342, DateTimeKind.Local).AddTicks(2120),
                            Horas = 35,
                            Precio = 205000.0
                        });
                });

            modelBuilder.Entity("PortafolioProyectos.Models.LenguajesPorProyecto", b =>
                {
                    b.HasOne("PortafolioProyectos.Models.Lenguaje", "Lenguaje")
                        .WithMany()
                        .HasForeignKey("LenguajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortafolioProyectos.Models.Proyecto", "Proyecto")
                        .WithMany()
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortafolioProyectos.Models.Proyecto", b =>
                {
                    b.HasOne("PortafolioProyectos.Models.Cliente", "Cliente")
                        .WithMany("Proyectos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortafolioProyectos.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
