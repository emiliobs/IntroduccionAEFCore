using IntroduccionAEFCore.Entidades;
using Microsoft.EntityFrameworkCore;

namespace IntroduccionAEFCore.Utilidades.Seeding
{
    public class SedingInicial
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var samuelLJackson = new Actor()
            {
                Id = 2,
                Nombre = "Samuel L. Jackson",
                FechaNacimiento = new DateTime(1948, 12, 21),
                Fortuna = 15000
            };
            var RobertDowneyJunior = new Actor()
            {
                Id = 3,
                Nombre = "Robert Downey Jr.",
                FechaNacimiento = new DateTime(1965, 4, 4),
                Fortuna = 18000
            };

            modelBuilder.Entity<Actor>().HasData(samuelLJackson, RobertDowneyJunior);

            var avengers = new Pelicula()
            {
                Id = 4,
                Titulo = "Avengers Endgame",
                FechaEstreno = new DateTime(2019, 4, 22)
            };
            var spiderManNWH = new Pelicula()
            {
                Id = 6,
                Titulo = "Spider-Man: No Way Home",
                FechaEstreno = new DateTime(2021, 12, 13)
            };
            var spiderManSpiderVerse2 = new Pelicula()
            {
                Id = 7,
                Titulo = "Spider-Man: Across the Spider-Verse (Part One)",
                FechaEstreno = new DateTime(2022, 10, 7)
            };

            modelBuilder.Entity<Pelicula>().HasData(avengers, spiderManNWH, spiderManSpiderVerse2);

            var comentarioAvengers = new Comentario()
            {
                Id = 3,
                Recomendar = true,
                Contenido = "Muy buena!!!",
                PeliculaId = avengers.Id
            };
            var comentarioAvengers2 = new Comentario()
            {
                Id = 4,
                Recomendar = true,
                Contenido = "Dura dura",
                PeliculaId = avengers.Id
            };
            var comentarioNWH = new Comentario()
            {
                Id = 5,
                Recomendar = false,
                Contenido = "no debieron hacer eso...",
                PeliculaId = spiderManNWH.Id
            };

            modelBuilder.Entity<Comentario>().HasData(comentarioAvengers, comentarioAvengers2, comentarioNWH);
        }
    }
}
