using IntroduccionAEFCore.Entidades;
using Microsoft.EntityFrameworkCore;

namespace IntroduccionAEFCore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Actor> Actores => Set<Actor>();

        public DbSet<Comentario> Comentarios { get; set; }

        public DbSet<Genero> Generos => Set<Genero>();

        public DbSet<Pelicula> Peliculas => Set<Pelicula>();

        public DbSet<PeliculaActor> PiliculasActores => Set<PeliculaActor>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        //protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        //{

        //    configurationBuilder.Properties<string>().HaveMaxLength(150);

        //    base.ConfigureConventions(configurationBuilder);
        //}
    }
}
