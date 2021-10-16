using System.Net.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Drone.App.Dominio;
using Drone.App.Persistencia;

namespace Drone.App.Frontend.Pages
{
    public class opcionesClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;

        [BindProperty]
        public Cliente Cliente {get; set;}

        public opcionesClienteModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente=repositorioCliente;
        }


        public void OnGet()
        {
            // var cedula = Request.Form["barCedula"];
            // Console.WriteLine(cedula);
        }
    }
}
