using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Veterinario> Veterinarios {get;set;}
        public DbSet<Propietario> Propietarios {get;set;}
        public DbSet<Visita> Visitas {get;set;}
        public DbSet<HistoriaClinica> Historias {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MascotaFelizData");
            }
        }
    }
}