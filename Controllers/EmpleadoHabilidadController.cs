using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppContoso.Data;

namespace WebAppContoso.Controllers
{
    public class EmpleadoHabilidadController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmpleadoHabilidadController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var item = _context.EmpleadoHabilidades.ToList();
            return View(item);
        }
    }
}
