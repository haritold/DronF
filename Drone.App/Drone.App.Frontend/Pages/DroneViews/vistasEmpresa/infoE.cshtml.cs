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
    public class infoEModel : PageModel
    {
        private readonly IRepositorioEncargado repositorioEncargado;

        [BindProperty]

        public Encargado Encargado {get; set;}

        public infoEModel(IRepositorioEncargado repositorioEncargado)
        {
            this.repositorioEncargado=repositorioEncargado;
        }

        public IActionResult OnGet(int encargadoId)
        {
            Encargado = repositorioEncargado.GetEncargadoPorId(encargadoId);
            if(Encargado==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
    }
}
