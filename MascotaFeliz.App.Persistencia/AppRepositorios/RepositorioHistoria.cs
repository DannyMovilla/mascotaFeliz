using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        private readonly AppContext _appContext;

        public RepositorioHistoria(AppContext appContext)
        {
            _appContext = appContext;
        }

        public HistoriaClinica AddHistoria(HistoriaClinica historia)
        {
            var historiaNuevo = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaNuevo.Entity;
        }

        public HistoriaClinica UpdateHistoria(HistoriaClinica historia)
        {
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(d => d.Id == historia.Id);
            if(historiaEncontrado != null){

                historiaEncontrado.FechaInicio = historia.FechaInicio;
                historiaEncontrado.Visita = historia.Visita;

                _appContext.SaveChanges();
            }
            return historiaEncontrado;
        }

        public IEnumerable<Visita> GetVisitaHistoria(int idHistoria)
        {
            var historia = _appContext.Historias.Where(h => h.Id == idHistoria)
                                                .Include(h => h.Visita)
                                                .FirstOrDefault();

            return historia.Visita;
        }
    }
}