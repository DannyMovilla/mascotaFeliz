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
    public class ConsultarVetModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        private static IRepositorioMascota repositorioMascota = new RepositorioMascota(new Persistencia.AppContext());

        [TempData]
        public string StatusMessage {get;set;}

        [BindProperty(SupportsGet = true)]
        public Veterinario Veterinario  { get; set; } 

        public Veterinario VaterinarioDel  { get; set; }

        public IEnumerable<Veterinario> veterinarios {get;set;}

        public ConsultarVetModel(IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario = new RepositorioVeterinario(new MascotaFeliz.App.Persistencia.AppContext());
        }

        public void OnGet(int idVeterinario, Veterinario veterinario)
        {

            Veterinario = veterinario;
            veterinarios = repositorioVeterinario.GetVeterinarioFiltro(Veterinario); 
            
            VaterinarioDel = repositorioVeterinario.GetVeterinario(idVeterinario);
            if (VaterinarioDel == null)
            {
                RedirectToPage("./NotFound");
            }
            else
            {
                Mascota dataMacota = new Mascota();
                Propietario dataPropietario = new Propietario();
                dataPropietario.Id = 0;
                dataMacota.Propietario = dataPropietario;

                dataMacota.Veterinario = VaterinarioDel;

                IEnumerable<Mascota> mascotas = repositorioMascota.GetMascotaFiltro(dataMacota); 

                if(mascotas.Count() == 0){
                    repositorioVeterinario.DeleteVeterinario(VaterinarioDel.Id);
                    //StatusMessage = "Información eliminada correctamente.";
                }else{
                    //StatusMessage = "No se puede eliminar por que información asociada.";
                }
                Page();
                return;
            } 
            
            StatusMessage = "";
        }
        
    }
}
