using System;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio
{
    public class Persona
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido"), StringLength(50)]
        public string Nombres {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido"), StringLength(50)]
        public string Apellidos {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido"), StringLength(50)]
        public string Direccion {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido"), StringLength(50)]
        public string Telefono {get; set;}
    }
}