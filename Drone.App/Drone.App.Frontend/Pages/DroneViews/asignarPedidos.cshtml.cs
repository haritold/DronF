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
    public class asignarPedidosModel : PageModel
    {
        private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext());

        public List<Encargado> ListaEncargado{get;set;}

        public void OnGet()
        {
            ListaEncargado = _repoEncargado.GetEncargado().ToList();
            //ListarPacientesCorazon();
        }
    }
}
