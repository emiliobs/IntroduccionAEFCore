using IntroduccionAEFCore.Entidades;
using Microsoft.EntityFrameworkCore;

namespace IntroduccionAEFCore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Genero> Generos => Set<Genero>();

        public DbSet<Actor> Actores => Set<Actor>();

        public DbSet<Pelicula> Peliculas => Set<Pelicula>();

        public DbSet<Comentario> Comentarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Genero>().HasKey(g => g.Id);
            modelBuilder.Entity<Genero>().Property(g => g.Nombre).HasMaxLength(150);

            modelBuilder.Entity<Actor>().Property(a => a.Nombre).HasMaxLength(150);
            modelBuilder.Entity<Actor>().Property(a => a.FechaNacimiento).HasColumnType("date");
            modelBuilder.Entity<Actor>().Property(a => a.Fortuna).HasPrecision(18, 2);

            modelBuilder.Entity<Pelicula>().Property(p => p.Titulo).HasMaxLength(150);
            modelBuilder.Entity<Pelicula>().Property(p => p.FechaEstreno).HasColumnType("date");

            modelBuilder.Entity<Comentario>().Property(c => c.Contenido).HasMaxLength(500);


            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {

            configurationBuilder.Properties<string>().HaveMaxLength(150);

            base.ConfigureConventions(configurationBuilder);
        }
    }
}
