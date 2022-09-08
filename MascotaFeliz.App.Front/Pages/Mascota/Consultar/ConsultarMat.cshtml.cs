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
    public class ConsultarMatModel : PageModel
    {

        private readonly IRepositorioMascota repositorioMascota;
        private static IRepositorioPropietario repositorioPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        private static IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        [BindProperty(SupportsGet = true)]
        public Mascota Mascota  { get; set; } 

        [BindProperty(SupportsGet = true)]
        public Veterinario Veterinario  { get; set; } 

        [BindProperty(SupportsGet = true)]
        public Propietario Propietario  { get; set; } 

        public Mascota MascotaDel  { get; set; } 

        public IEnumerable<Mascota> mascotas {get;set;}
        public IEnumerable<Propietario> propietarios {get; set;}
        public IEnumerable<Veterinario> veterinarios {get; set;}

        public ConsultarMatModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
            propietarios = repositorioPropietario.GetAllPropietarios();
            veterinarios = repositorioVeterinario.GetAllVeterinarios();
        }

        public void OnGet(int idMascota, Mascota mascota)
        {

            Mascota = mascota;
            Mascota.Propietario = Propietario;
            Mascota.Veterinario = Veterinario;
            mascotas = repositorioMascota.GetMascotaFiltro(Mascota); 

            MascotaDel = repositorioMascota.GetMascota(idMascota);
            if (MascotaDel == null)
            {
                RedirectToPage("./NotFound");
            }
            else
            {
                repositorioMascota.DeleteMascota(MascotaDel.Id);
                Page();
            } 
        }
    }
}
