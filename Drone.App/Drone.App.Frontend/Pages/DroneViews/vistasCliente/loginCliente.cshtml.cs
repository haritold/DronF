using System.Net.Security;
using System.Net.Http;
using System.Net.WebSockets;
using System.IO;
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
    public class loginClienteModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;

        [BindProperty]

        public Cliente Cliente {get; set;}

        public loginClienteModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente=repositorioCliente;
        }

        public IActionResult OnGet(int? clienteId)
        {
            if(clienteId.HasValue)
            {
                Cliente = repositorioCliente.GetClientePorId(clienteId.Value);
            }
            else
            {
                Cliente = new Cliente();
            }

            if(Cliente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }

            
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Cliente.Id>0)
            {
                Cliente = repositorioCliente.Update(Cliente);
            }
            else
            {
                repositorioCliente.AddCliente(Cliente);
            }
            return Page();

        }


    }
}
