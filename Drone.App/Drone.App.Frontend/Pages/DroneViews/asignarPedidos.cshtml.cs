using System.Diagnostics;
using System.Globalization;
using System.Data;
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
    public class asignarPedidosModel : PageModel
    {
        private readonly IRepositorioEncargado repositorioEncargado;
            
        public IEnumerable<Encargado> Encargados{get; set;}

        public asignarPedidosModel(IRepositorioEncargado repositorioEncargado)
        {
            this.repositorioEncargado=repositorioEncargado;
        }


        public void OnGet()
        {
            Encargados = repositorioEncargado.GetAll();
           
        }
    }
}
