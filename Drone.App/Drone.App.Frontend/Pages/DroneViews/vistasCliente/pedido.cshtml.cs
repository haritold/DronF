using System.Net.Cache;
using System.Globalization;
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
        private static IRepositorioPedido _repoPedido = new RepositorioPedido(new Persistencia.AppContext()); 

        [BindProperty]
        public IEnumerable<Producto> InventarioProd{get; set;}

        [BindProperty]
        public IEnumerable<Producto> Carrito{get; set;}

        public void OnGet()
        {
            InventarioProd= _repoPedido.GetAllInventario();
            Carrito= _repoPedido.GetAllCarrito();
        }

        public IActionResult OnPost()
        {
            var productoSel = Request.Form["selectedProduct"];
            int idProd = Convert.ToInt32(productoSel);

            var produ = _repoPedido.GetProductoPorId(idProd);

            _repoPedido.AddToCarrito(produ);

            Carrito= _repoPedido.GetAllCarrito();
            InventarioProd = _repoPedido.GetAllInventario();

            // AddPedidoConProductos();

            return Page();
        }




        private static void AddPedidoConProductos()
        {
            DateTime localDate = DateTime.Now;
            DateTime myTime = localDate;

            Console.WriteLine(myTime.ToString());
        
            var pedido = new Pedido
            {
                Fecha = myTime,

                Productos =_repoPedido.GetAllCarrito().ToList()

            };
            _repoPedido.AddPedido(pedido);
        }



    }
}
