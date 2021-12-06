using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppContoso.Models
{
    public class Empleado
    {
    public int Id { get; set; }

    [Required(ErrorMessage = "Nombre Requerido.")]
    //[Display(Name = "Nombre Electrónico")]
    public string Nombre { get; set; }
        
    [Required(ErrorMessage = "Apellido Requerido.")]
   // [Display(Name = "Apellido Electrónico")]
    public string Apellido { get; set; }

    [Required(ErrorMessage = "Correo Requerido.")]
    [EmailAddress]
    //[Display(Name = "Correo Electrónico")]
    public string Correo { get; set; }

    [Required(ErrorMessage = "Teléfono Requerido.")]
    [Phone]
    [Display(Name = "Teléfono Electrónico")]
    public string RolNum { get; set; }

    [Required(ErrorMessage = "Habilidad Requerida")]
   // [Display(Name = "Habilidad Requerida")]
    public List<EmpleadoHabilidad> EmpleadoHabilidad { get; set; }
    }
}
