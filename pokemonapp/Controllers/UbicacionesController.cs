using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            //otra opcion para traer los datos de la base de datos a la web
            var regiones=_context.Regiones.Include(x=>x.Pueblos).OrderBy(r=> r.Nombre).ToList();
            //var regiones=_context.Regiones.OrderBy(r=> r.Nombre).ToList();
            return View(regiones);
        }
        public IActionResult Pueblos(){
            //otra opcion para traer los datos de la base de datos a la web
            var pueblos=_context.Pueblos.Include(x=>x.Region).OrderBy(r=> r.Nombre).ToList();
            //var regiones=_context.Regiones.OrderBy(r=> r.Nombre).ToList();
            return View(pueblos);
        }
        public IActionResult NuevoPueblo(){
            //LISTA DE COLECCIONES
            ViewBag.Regiones = _context.Regiones.ToList().Select(r =>new SelectListItem(r.Nombre,r.Id.ToString()));
            return View();
        }
        //
        [HttpPost]
        public IActionResult NuevoPueblo(Pueblo r){
             if(ModelState.IsValid){
                _context.Add(r);
                _context.SaveChanges();

                return RedirectToAction("NuevoPuebloConfirmacion");
            }
            return View(r);
        }
        public IActionResult NuevoPuebloConfirmacion(){
            return View();
        }
        //PRG = de pueblo esta lista
        public IActionResult NuevaRegion(){
            return View();
        }
        //
        [HttpPost]
        public IActionResult NuevaRegion(Region r){
             if(ModelState.IsValid){
                _context.Add(r);
                _context.SaveChanges();

                return RedirectToAction("NuevaRegionConfirmacion");
            }
            return View(r);
        }
        public IActionResult NuevaRegionConfirmacion(){
            return View();
        }
        [HttpPost]
        public IActionResult BorrarRegion(int id){
            var region=_context.Regiones.Find(id);
            _context.Remove(region);
            _context.SaveChanges();
            return RedirectToAction("Regiones");
            //_context.Regiones.First(r=>r.Id==id);
        }
        public IActionResult EditarRegion(int id){
            var region=_context.Regiones.Find(id);
            return View(region);
        }
        //
        [HttpPost]
        public IActionResult EditarRegion(Region r){
            if(ModelState.IsValid){
                var region=_context.Regiones.Find(r.Id);
                region.Nombre=r.Nombre;
                _context.SaveChanges();

                return RedirectToAction("EditarRegionConfirmacion");
            }
            return View(r);
        }
        public IActionResult EditarRegionConfirmacion(){
            return View();
        }

    }
}