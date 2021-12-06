using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppContoso.Models
{
    public class Habilidad
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<EmpleadoHabilidad> EmpleadoHabilidad { get; set;}
    }
}
