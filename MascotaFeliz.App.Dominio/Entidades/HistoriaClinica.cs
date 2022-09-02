using System;
using System.Collections.Generic;

namespace MascotaFeliz.App.Dominio
{
    public class HistoriaClinica
    {
        public int Id {get; set;}
        public DateTime FechaInicio {get; set;}
        public List<Visita> Visita {get;set;}
    }
}