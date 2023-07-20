namespace IntroduccionAEFCore.Entidades
{
    public class Genero
    {
        public int Id { get; set; }

        //[StringLength(maximumLength:150)]
        public String Nombre { get; set; } = null!;

        public HashSet<Pelicula> Peliculas { get; set; } = new HashSet<Pelicula>();
    }
}
