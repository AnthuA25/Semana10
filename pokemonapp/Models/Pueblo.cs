using System.Collections.Generic;

namespace pokemonapp.Models
{
    public class Pueblo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Region Region { get; set; }
        public ICollection<Entrenador> Entrenadores { get; set; }
    }
}