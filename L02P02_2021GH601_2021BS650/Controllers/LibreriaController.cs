using L02P02_2021GH601_2021BS650.Models;
using Microsoft.AspNetCore.Mvc;

namespace L02P02_2021GH601_2021BS650.Controllers
{
    public class LibreriaController : Controller
    {

        public IActionResult Index()
        {
            var listLibros = (from l in _libreriaDBContext.libros
                              select l).ToList();
            ViewData["listLibros"] = listLibros;

            return View();
        }

        private readonly libreriaDbContext _libreriaDBContext;
        public LibreriaController(libreriaDbContext libreriaDBContext)
        {
            _libreriaDBContext = libreriaDBContext;
        }

        public IActionResult CrearLibro(libros nuevolibro)
        {
            _libreriaDBContext.Add(nuevolibro);
            _libreriaDBContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult EliminarLibro(int id)
        {
            libros? libro = (from l in _libreriaDBContext.libros
                             where l.id == id
                             select l).FirstOrDefault();

            if (libro == null)
                return NotFound();

            _libreriaDBContext.libros.Attach(libro);
            _libreriaDBContext.libros.Remove(libro);
            _libreriaDBContext.SaveChanges();

            return Ok(libro);
        }

    }
}
