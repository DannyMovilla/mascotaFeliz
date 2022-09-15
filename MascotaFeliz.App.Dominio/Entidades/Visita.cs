using System;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio
{
    public class Visita
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public float Temperatura {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public float Peso {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public float FrecuenciaRespiratoria {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public float FrecuenciaCardiaca {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido"), StringLength(50)]
        public string EstadoAnimo {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime FechaVisita {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido"), StringLength(50)]
        public string Recomendaciones {get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int IdVeterinario {get; set;}
    }
}