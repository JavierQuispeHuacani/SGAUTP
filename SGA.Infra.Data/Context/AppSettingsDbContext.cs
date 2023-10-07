using SGA.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Infra.Data.Context
{
    public class AppSettingsDbContext : DbContext
    {

        public AppSettingsDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Usuario>().HasKey(e => e.Cod_Usuario);
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Area>().HasKey(e => e.Codigo_Area);
            modelBuilder.Entity<Area>().ToTable("Area");
            modelBuilder.Entity<Cargo>().HasKey(e => e.Codigo_Cargo);
            modelBuilder.Entity<Cargo>().ToTable("Cargo");
        }
    }
}
