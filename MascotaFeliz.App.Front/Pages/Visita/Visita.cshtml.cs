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
    public class VisitaModel : PageModel
    {
        private readonly IRepositorioVisita repositorioVisita;
        private static IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota repositorioMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioHistoria repositorioHistoria = new RepositorioHistoria(new Persistencia.AppContext());

        [BindProperty]
        public Visita VisitaSave  { get; set; } 

        [BindProperty]
        public Mascota mascotaSave { get; set; }

        public IEnumerable<Veterinario> veterinarios {get; set;}
        public IEnumerable<Mascota> mascotas {get; set;}

        public VisitaModel(IRepositorioVisita repositorioVisita)
        {
            this.repositorioVisita = new RepositorioVisita(new MascotaFeliz.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int? mascotaId)
        {   
            veterinarios = repositorioVeterinario.GetAllVeterinarios();
            VisitaSave = new Visita();
            
            if (mascotaId.HasValue)
            {
                mascotaSave = repositorioMascota.GetMascota(mascotaId.Value);
            }
            
            if (mascotaSave == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost(Visita VisitaSave, Mascota mascotaSave)
        {
            if(!ModelState.IsValid)
            {
                mascotaSave = repositorioMascota.GetMascota(mascotaSave.Id);

                if(Object.ReferenceEquals(null, mascotaSave.HistoriaClinica)){
                    
                    DateTime localDate = DateTime.Now;

                    var historia = new HistoriaClinica{
                        FechaInicio = DateTime.Now,
                        Visita = new List<Visita> {
                            VisitaSave
                        }
                    };
                    mascotaSave.HistoriaClinica = repositorioHistoria.AddHistoria(historia);
                    repositorioMascota.UpdateMascota(mascotaSave);
                }else{
                    var historia = mascotaSave.HistoriaClinica;
                   
                    IEnumerable<Visita> dataList = repositorioHistoria.GetVisitaHistoria(historia.Id);

                    var visitas = new List<Visita>(dataList);
                    visitas.Add(VisitaSave);

                    historia.Visita = visitas;

                    repositorioHistoria.UpdateHistoria(historia);
                }
            
                return RedirectToPage("../Mascota/Consultar/ConsultarMat");
            }
            else
            {            
                return Page();
            }
        } 
    }
}
