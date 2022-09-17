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
    public class UpdVisitaModel : PageModel
    {
        private readonly IRepositorioVisita repositorioVisita;
        private static IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        [BindProperty]
        public Visita Visita  { get; set; } 

        [BindProperty]
        public IEnumerable<Veterinario> veterinarios {get; set;}

        public UpdVisitaModel(IRepositorioVisita repositorioVisita)
        {
            this.repositorioVisita = new RepositorioVisita(new MascotaFeliz.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int? visitaId)
        {
            if (visitaId.HasValue)
            {
                Visita = repositorioVisita.GetVisita(visitaId.Value);
                veterinarios = repositorioVeterinario.GetAllVeterinarios();
            }
            else
            {
                Visita = new Visita();
            }
            if (Visita == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Visita.Id>0)
            {
            Visita = repositorioVisita.UpdateVisita(Visita);
            }
            /*else
            {
             repositorioPropietario.AddPropietario(Propietario);
            }*/
            return Page();
        } 
    }
}
