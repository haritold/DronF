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
    public class loginEmpresaModel : PageModel
    {

        private readonly IRepositorioEmpresa repositorioEmpresa;

        [BindProperty]
        public Empresa Empresa {get; set;}

        public loginEmpresaModel(IRepositorioEmpresa repositorioEmpresa)
        {
            this.repositorioEmpresa=repositorioEmpresa;
        }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            var usuarioE = repositorioEmpresa.GetEmpresaPorUser(Empresa.RazonSocial);
            var passwordE = repositorioEmpresa.GetEmpresaPorPass(Empresa.PasswordEmp);

            if(usuarioE != null && passwordE != null)
            {
                Console.WriteLine("You are in");
                return RedirectToPage("./opcionesEmpresa");
            }
            else
            {
                Console.WriteLine("Try again");
                return Page();
            }
        }

    }
}
