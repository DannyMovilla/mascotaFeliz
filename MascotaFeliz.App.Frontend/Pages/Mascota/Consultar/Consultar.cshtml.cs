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
    public class ConsultarModel : PageModel
    {

        private readonly IRepositorioPropietario repositorioPropietario;

        public IEnumerable<Propietario> propietarios {get;set;}

        public ConsultarModel(IRepositorioPropietario repositorioPropietario)
        {
            this.repositorioPropietario=new RepositorioPropietario(new MascotaFeliz.App.Persistencia.AppContext());
        }

        public void OnGet()
        {
            propietarios = repositorioPropietario.GetAllPropietarios();
        }
    }
}
