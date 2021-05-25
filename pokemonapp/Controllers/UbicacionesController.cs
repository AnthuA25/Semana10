using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pokemonapp.Models;

namespace pokemonapp.Controllers
{
    public class UbicacionesController : Controller
    {
        private readonly PokemonContext _context;
        public UbicacionesController(PokemonContext context){
            _context=context;
        }

        public IActionResult Regiones(){
            var regiones=_context.Regiones.OrderBy(r=> r.Nombre).ToList();
            return View();
        }
    }
}