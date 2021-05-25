using System.Collections.Generic;

namespace pokemonapp.Models
{
    public class Pueblo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Region Region { get; set; }
        //propiedad sombra o EF Shadow property(Almacenar el Id de la clave foranea que esta relacionada a esa entidad)
        public int RegionId { get; set; }
        public ICollection<Entrenador> Entrenadores { get; set; }
    }
}