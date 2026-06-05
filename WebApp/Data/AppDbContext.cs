using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Proyector> Proyectores { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Departamento>()
                .ToTable("Departamentos")
                //.HasMany(e => e.Proyectores)
                //.WithOne(e => e.Departamento)
                //.HasForeignKey(e => e.DepartamentoId)
                //.IsRequired()
                .HasData(
                    new Departamento() 
                    { 
                        Id = 1,
                        Titulo = "DEPARTAMENTO DE SISTEMAS Y COMPUTACION"
                    },
                    new Departamento()
                    {
                        Id = 2,
                        Titulo = "DEPARTAMENTO DE INGENIERIA INDUSTRIAL"
                    },
                    new Departamento()
                    {
                        Id = 3,
                        Titulo = "DEPARTAMENTO DE CIENCIAS DE LA TIERRA"
                    },
                    new Departamento()
                    {
                        Id = 4,
                        Titulo = "DEPARTAMENTO DE CIENCIAS ECONOMICO-ADMINISTRATIVAS"
                    },
                    new Departamento()
                    {
                        Id = 5,
                        Titulo = "DEPARTAMENTO DE INGENIERIA METAL-MECANICA"
                    },
                    new Departamento()
                    {
                        Id = 6,
                        Titulo = "DEPARTAMENTO DE INGENIERIA QUIMICA Y BIOQUIMICA"
                    },
                    new Departamento()
                    {
                        Id = 7,
                        Titulo = "DEPARTAMENTO DE CIENCIAS BASICAS"
                    }
                );

            modelBuilder.Entity<Proyector>()
                .ToTable("Proyectores")
                .HasOne(e => e.Departamento)
                .WithMany(e => e.Proyectores)
                .HasForeignKey(e => e.DepartamentoId)
                .IsRequired();
        }

    }
}
