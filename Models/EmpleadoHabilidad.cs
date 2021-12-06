using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppContoso.Models
{
    public class EmpleadoHabilidad
    {
        public int EmpleadoId { get; set; }

        public Empleado Empleado { get; set; }

        public int HabilidadId { get; set; }

        public Habilidad Habilidad { get; set; }
    }
}
