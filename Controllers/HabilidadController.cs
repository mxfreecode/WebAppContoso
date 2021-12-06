using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppContoso.Data;
using WebAppContoso.Models;

namespace WebAppContoso.Controllers
{
    public class HabilidadController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HabilidadController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            var item = _context.Habilidades.ToList();
            return View(item);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Habilidad habilidades)
        {
            _context.Habilidades.Add(habilidades);
            _context.SaveChanges();
            return RedirectToAction("Index", "Habilidad");
        }
        
    }
}
