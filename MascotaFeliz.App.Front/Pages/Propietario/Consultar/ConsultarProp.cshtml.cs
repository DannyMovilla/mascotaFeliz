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
    public class ConsultarPropModel : PageModel
    {

        [TempData]
        public string StatusMessage {get;set;}
       
        private readonly IRepositorioPropietario repositorioPropietario;
        private static IRepositorioMascota repositorioMascota = new RepositorioMascota(new Persistencia.AppContext());
        
        [BindProperty(SupportsGet = true)]
        public Propietario Propietario  { get; set; } 

        public Propietario PropietarioDel  { get; set; } 

        public IEnumerable<Propietario> propietarios {get;set;}

        public ConsultarPropModel(IRepositorioPropietario repositorioPropietario)
        {
            this.repositorioPropietario=new RepositorioPropietario(new MascotaFeliz.App.Persistencia.AppContext());
        }

        public void OnGet(int idPropietario, Propietario propietario)
        {

            Propietario = propietario;
            propietarios = repositorioPropietario.GetPropietarioFiltro(Propietario); 

            PropietarioDel = repositorioPropietario.GetPropietario(idPropietario);
            if (PropietarioDel == null)
            {
                RedirectToPage("./NotFound");
            }
            else
            {
                Mascota dataMacota = new Mascota();
                dataMacota.Propietario = PropietarioDel;

                Veterinario dataVeterinario = new Veterinario();
                dataVeterinario.Id = 0;

                dataMacota.Veterinario = dataVeterinario;

                IEnumerable<Mascota> mascotas = repositorioMascota.GetMascotaFiltro(dataMacota); 

                if(mascotas.Count() == 0){
                    repositorioPropietario.DeletePropietario(PropietarioDel.Id);
                    //StatusMessage = "Información eliminada correctamente.";
                }
                else
                {
                    //StatusMessage = "No se puede eliminar por que información asociada.";
                }
                
                Page();
            } 
        }
        
    }
}
