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
        private readonly IRepositorioPedido repositorioPedido;

        public IEnumerable<Producto> Inventario{get; set;}

        public pedidoModel(IRepositorioPedido repositorioPedido)
        {
            this.repositorioPedido=repositorioPedido;
        }


        ///ONGET
        public void OnGet()
        {
            Inventario=repositorioPedido.GetAllInventario();
        }





        ///ONPOST
       
    }
}
