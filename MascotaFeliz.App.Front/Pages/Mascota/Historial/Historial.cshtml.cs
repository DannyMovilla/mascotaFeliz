using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia;
using MascotaFeliz.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace MascotaFeliz.App.Frontend.Pages
{
    [Authorize]
    public class HistorialModel : PageModel
    {
        
        private readonly IRepositorioHistoria repositorioHistoria;
        private static IRepositorioMascota repositorioMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        public Mascota Mascota { get; set; }
        public Veterinario veterinario { get; set; }

        public IEnumerable<Visita> visitas {get; set;}

        public HistorialModel(IRepositorioHistoria repositorioHistoria)
        {
            this.repositorioHistoria = new RepositorioHistoria(new MascotaFeliz.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int? mascotaId)
        {
            if (mascotaId.HasValue)
            {
                Mascota = repositorioMascota.GetMascota(mascotaId.Value);

                if(!Object.ReferenceEquals(null, Mascota.HistoriaClinica)){
                    var historia = Mascota.HistoriaClinica;   
                    visitas = repositorioHistoria.GetVisitaHistoria(historia.Id);
                }else{

                }
               
            }

            if (Mascota == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }
    }
}
