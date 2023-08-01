using IntroduccionAEFCore.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntroduccionAEFCore.Utilidades
{
    public class GEnroConfig : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            var cienciaFiccion = new Genero { Id = 6, Nombre = "Ciencia Ficción" };
            var animacion = new Genero { Id = 7, Nombre = "Animación" };
            builder.HasData(cienciaFiccion, animacion);
        }
    }
}
