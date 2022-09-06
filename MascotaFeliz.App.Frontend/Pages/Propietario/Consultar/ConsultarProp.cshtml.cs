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
    public class ConsultarPropModel : PageModel
    {
       
        private readonly IRepositorioPropietario repositorioPropietario;
        
        [BindProperty(SupportsGet = true)]
        public Propietario Propietario  { get; set; } 

        public IEnumerable<Propietario> propietarios {get;set;}

        public ConsultarPropModel(IRepositorioPropietario repositorioPropietario)
        {
            this.repositorioPropietario=new RepositorioPropietario(new MascotaFeliz.App.Persistencia.AppContext());
        }

        public void OnGet()
        {
            propietarios = repositorioPropietario.GetAllPropietarios();
        }
        
    }
}
