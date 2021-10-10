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
    public class editarEncargadoModel : PageModel
    {
        private readonly IRepositorioEncargado repositorioEncargado;

        [BindProperty]

        public Encargado Encargado {get; set;}

        public editarEncargadoModel(IRepositorioEncargado repositorioEncargado)
        {
            this.repositorioEncargado=repositorioEncargado;
        }

        /// ONGET

        public IActionResult OnGet(int? encargadoId)
        {   
            if(encargadoId.HasValue)
            {
                Encargado = repositorioEncargado.GetEncargadoPorId(encargadoId.Value);
            }
            else
            {
                Encargado = new Encargado();
            }

            if(Encargado == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }

        }


        /// ONPOST

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            if(Encargado.Id > 0)
            {
                Encargado = repositorioEncargado.Update(Encargado);
            }
            else
            {
                repositorioEncargado.Add(Encargado);
            }

            return Page();
        }


    }
}
