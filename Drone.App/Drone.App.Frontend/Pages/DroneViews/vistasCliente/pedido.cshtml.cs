using System.IO;
using System.Globalization;
using System.Collections;
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
    public class pedidoModel : PageModel
    {
        private readonly IRepositorioProducto repositorioProducto;

        public IEnumerable<Producto> Productos{get; set;}

        public pedidoModel(IRepositorioProducto repositorioProducto)
        {
            this.repositorioProducto=repositorioProducto;
        }

        public void OnGet()
        {
            Productos=repositorioProducto.GetAll();
        }
    }
}
