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
        // private readonly RepositorioPedido repositorioPedido;

        [BindProperty]
        public Cliente Cliente {get; set;}



        public loginClienteModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente=repositorioCliente;
            // this.repositorioPedido=repositorioPedido;
        }


        ///ONGET
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


        ///ONPOST
        public IActionResult OnPostButton1()
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

            return RedirectToPage("./opcionesCliente");
            
            
        }

        public IActionResult OnPostButton2()
        {
            var cedulaC = repositorioCliente.GetClientePorCedula(Cliente.Cedula);
            var password = repositorioCliente.GetClientePorPass(Cliente.PasswordClie);

            if(cedulaC != null && password != null)
            {
                Console.WriteLine("You are in");
                int idCliente= repositorioCliente.GetClienteId(Cliente.Cedula);
                Console.WriteLine(idCliente);
                return RedirectToPage("./opcionesCliente");
            }
            else
            {
                Console.WriteLine("Try again");
                return Page();
            }
            
            
        }





    }
}
