using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Persistencia;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ConsultarMatModel : PageModel
    {

        private readonly IRepositorioMascota repositorioMascota;

        public IEnumerable<Mascota> mascotas {get;set;}

        public ConsultarMatModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota = new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
        }

        public void OnGet()
        {
            mascotas = repositorioMascota.GetAllMascotas();
        }
    }
}
