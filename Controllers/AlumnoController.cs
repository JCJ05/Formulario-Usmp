using Microsoft.AspNetCore.Mvc;
using Formulario_Usmp.Models;
using Formulario_Usmp.Data;


namespace Formulario_Usmp.Controllers
{
    public class AlumnoController:Controller
    {

        private readonly ApplicationDbContext _context;

        public AlumnoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() {

            return View();

        }

        public IActionResult Guardar(Alumno alumno) {

            _context.Add(alumno);
            _context.SaveChanges();
            
            ViewData["Message"] = "El contacto se guardo correctamente"; 
             return View("Index");

        }


        
    }
}