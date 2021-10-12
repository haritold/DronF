using System.Net.Cache;
using System.Net.Http.Headers;
using System.Net.Http;
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


        [BindProperty]
        public IEnumerable<Producto> Productos{get; set;}

        [BindProperty]
        public IEnumerable<Producto> Carrito{get; set;}

        [BindProperty]
        public int cantidad {get; set;}

        public pedidoModel(IRepositorioProducto repositorioProducto)
        {
            this.repositorioProducto=repositorioProducto;
        }

        public void OnGet()
        {
            Productos=repositorioProducto.GetAll();
        }

        public IActionResult OnPost()
        {
            var producS = Request.Form["selectedProduct"];
            // repositorioProducto.AddToCarrito(producS);

            var cantidad = Request.Form["cantidadProductos"];
    
            Console.WriteLine(producS);

            return Page();
        }
    }
}
