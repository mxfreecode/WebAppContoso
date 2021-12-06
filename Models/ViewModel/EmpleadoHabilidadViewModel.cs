using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppContoso.Models.ViewModel
{
    public class EmpleadoHabilidadViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Correo { get; set; }

        public string RolNum { get; set; }

        public List<CheckBoxItem> Habilidades { get; set; }
    }
}

