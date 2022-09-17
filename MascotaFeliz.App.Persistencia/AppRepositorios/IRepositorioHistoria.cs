using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        HistoriaClinica AddHistoria (HistoriaClinica historia);

        HistoriaClinica UpdateHistoria (HistoriaClinica historia);

        IEnumerable<Visita> GetVisitaHistoria(int idHistoria);
    }
}