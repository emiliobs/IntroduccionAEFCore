namespace IntroduccionAEFCore.Entidades
{
    public class Comentario
    {
        public int Id { get; set; }

        public string? Contenido { get; set; }

        public bool Recomendar { get; set; }


        //propiedad de navegacion:

        public int PeliculaId { get; set; }

        public Pelicula Pelicula { get; set; } = null!;
    }
}
