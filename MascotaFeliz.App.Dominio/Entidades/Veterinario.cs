using System;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio
{
    public class Veterinario:Persona
    {
        [Required(ErrorMessage = "El campo {0} es requerido"), StringLength(50)]
        public string TarjetaProfesional {get; set;}
    }
}