using System.Collections.Generic;

namespace pokemonapp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Tipo> Tipos { get; set; }
    }
}