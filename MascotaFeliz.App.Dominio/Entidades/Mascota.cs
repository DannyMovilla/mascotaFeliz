using System;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio
{
    public class Mascota
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido"), StringLength(50)]
        public string Nombre {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido"), StringLength(50)]
        public string Color {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido"), StringLength(50)]
        public string Especie {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido"), StringLength(50)]
        public string Raza {get; set;}
        public Propietario Propietario {get; set;}
        public Veterinario Veterinario {get; set;}
        public HistoriaClinica HistoriaClinica {get; set;} 
    }
}