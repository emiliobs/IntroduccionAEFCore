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
    }
}
