using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppContoso.Data;
using WebAppContoso.Models;
using WebAppContoso.Models.ViewModel;

namespace WebAppContoso.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmpleadoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var item = _context.Empleados.ToList();
            return View(item);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var item = _context.Habilidades.ToList();
            EmpleadoHabilidadViewModel m1 = new EmpleadoHabilidadViewModel();
            m1.Habilidades = item.Select(vm => new CheckBoxItem()
            {
                Id = vm.Id,
                Titulo = vm.Title,
                IsChecked = false
            }).ToList();
            return View(m1);
            
        }
        [HttpPost]
        public IActionResult Create(EmpleadoHabilidadViewModel EHM, Empleado empleados, EmpleadoHabilidad EH)
        {
            List<EmpleadoHabilidad> stc = new List<EmpleadoHabilidad>();
            empleados.Nombre = EHM.Nombre;
            empleados.Apellido = EHM.Apellido;
            empleados.Correo = EHM.Correo;
            empleados.RolNum = EHM.RolNum;
            _context.Empleados.Add(empleados);
            _context.SaveChanges();
            int empleadoid = empleados.Id;

            foreach (var item in EHM.Habilidades)
            {
                if (item.IsChecked == true)
                {
                    stc.Add(new EmpleadoHabilidad() { EmpleadoId = empleadoid, HabilidadId = item.Id });
                }
            }
            foreach (var item in stc)
            {
                _context.EmpleadoHabilidades.Add(item);
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Empleado");
        }
    }
}
