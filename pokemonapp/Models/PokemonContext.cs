using Microsoft.EntityFrameworkCore;

namespace pokemonapp.Models
{
    public class PokemonContext : DbContext
    {
        public DbSet<Entrenador> Entrenadores{ get; set; }
        public DbSet<Pueblo> Pueblos{ get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<Pokemon> Pokemones { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public PokemonContext(DbContextOptions dco) : base(dco){
            
        }
    }
}
