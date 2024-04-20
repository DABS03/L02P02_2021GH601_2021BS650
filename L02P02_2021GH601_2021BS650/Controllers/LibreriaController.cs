using L02P02_2021GH601_2021BS650.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace L02P02_2021GH601_2021BS650.Controllers
{
    public class LibreriaController : Controller
    {

        public IActionResult Index()
        {
            var listLibros = (from l in _libreriaDBContext.libros
                              select l).ToList();
            ViewData["listLibros"] = listLibros;

            var listaAutores = (from m in _libreriaDBContext.autores
                                select m).ToList();
            ViewData["listadodeautores"] = new SelectList(listaAutores, "id", "autor");

            var listaCat = (from m in _libreriaDBContext.categorias
                            select m).ToList();
            ViewData["listadodecategoria"] = new SelectList(listaCat, "id", "categoria");

            return View();
        }

        private readonly libreriaDbContext _libreriaDBContext;
        public LibreriaController(libreriaDbContext libreriaDBContext)
        {
            _libreriaDBContext = libreriaDBContext;
        }
        [HttpPost]
        public IActionResult CrearLibro(libros nuevolibro)
        {
            _libreriaDBContext.Add(nuevolibro);
            _libreriaDBContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EliminarLibro(int id)
        {
            libros libro = _libreriaDBContext.libros.FirstOrDefault(l => l.id == id);

            if (libro == null)
                return NotFound();

            _libreriaDBContext.libros.Remove(libro);
            _libreriaDBContext.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
