using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using T3_Espinoza_Diego.Data;
using T3_Espinoza_Diego.Models;

namespace T3_Espinoza_Diego.Controllers
{
    [Authorize]
    public class LibroController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LibroController(ApplicationDbContext context)
        {
            _context = context;
        }

        // LISTAR LIBROS
        public IActionResult Index()
        {
            IEnumerable<Libro> listaLibros = _context.Libros;
            return View(listaLibros);
        }

        // MOSTRAR FORMULARIO CREAR
        public IActionResult Crear()
        {
            return View();
        }

        // GUARDAR NUEVO LIBRO
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libros.Add(libro);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(libro);
        }

        // MOSTRAR FORMULARIO EDITAR
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var libro = _context.Libros.Find(id);

            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        // GUARDAR CAMBIOS
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libros.Update(libro);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(libro);
        }

        // MOSTRAR FORMULARIO ELIMINAR
        public IActionResult Eliminar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var libro = _context.Libros.Find(id);

            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        // ELIMINAR LIBRO
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EliminarPost(int? id)
        {
            var libro = _context.Libros.Find(id);

            if (libro == null)
            {
                return NotFound();
            }

            _context.Libros.Remove(libro);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}   

