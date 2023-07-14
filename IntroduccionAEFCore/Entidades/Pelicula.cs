namespace IntroduccionAEFCore.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = null!;

        public bool EnCInes { get; set; }

        public DateTime FechaEstreno { get; set; }
    }
}
