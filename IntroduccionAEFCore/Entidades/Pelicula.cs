namespace IntroduccionAEFCore.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = null!;

        public bool EnCInes { get; set; }

        public DateTime FechaEstreno { get; set; }

        //propiedad de navegacion:
        public HashSet<Comentario> Comentarios { get; set; } = new HashSet<Comentario>();

        public HashSet<Genero> Generos { get; set; } = new HashSet<Genero>();

        public List<PeliculaActor> PeliculasActores { get; set; } = new List<PeliculaActor>();


    }
}
