using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppContoso.Models;

namespace WebAppContoso.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Habilidad> Habilidades { get; set; }

        public DbSet<EmpleadoHabilidad> EmpleadoHabilidades { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<EmpleadoHabilidad>()
            .HasKey(c => new { c.EmpleadoId, c.HabilidadId });

            builder.Entity<EmpleadoHabilidad>()
                .HasOne(sc => sc.Empleado)
                .WithMany(c => c.EmpleadoHabilidad)
                .HasForeignKey(sc => sc.EmpleadoId);
            builder.Entity<EmpleadoHabilidad>()
               .HasOne(sc => sc.Habilidad)
               .WithMany(c => c.EmpleadoHabilidad)
               .HasForeignKey(sc => sc.HabilidadId);
        }
    }
}
