namespace infraestructure
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using domain.entities.countries;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    public class CountryDBContext : DbContext 
    {
        public CountryDBContext (DbContextOptions<CountryDBContext> options) : base (options) { }
        
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<City>()
                        .Property(c => c.Id)
                        .HasColumnName("Id");
            modelBuilder.Entity<City>()
                        .Property(c => c.Name)
                        .HasColumnName("Name");   
            modelBuilder.Entity<City>()                        
                        .HasOne(p => p.Sate);
                                                               
            modelBuilder.Entity<City>().HasKey(vf => new { vf.Id });

            modelBuilder.Entity<State>().ToTable("States");
            modelBuilder.Entity<State>()
                        .Property(c => c.Id)
                        .HasColumnName("Id");
            modelBuilder.Entity<State>()
                        .Property(c => c.Name)
                        .HasColumnName("Name");                   
            modelBuilder.Entity<State>().HasKey(vf => new { vf.Id });
        }
      
    }
}