using System.Linq;
using Drone.App.Dominio;
using System.Collections.Generic;

namespace Drone.App.Persistencia
{
    public class RepositorioProducto:IRepositorioProducto
    {
        ///PSEUDO DATABASE

        List<Producto> productos;
        List<Producto> carrito;
        

        public RepositorioProducto()
        {
            productos = new List<Producto>()
            {
                new Producto{Id=1, Nombre="Libro- Autofact", Precio=35000},
                new Producto{Id=2, Nombre="HardDrive- Kingston 1Th", Precio=450000},
                new Producto{Id=3, Nombre="BT Speaker", Precio=250000},
                new Producto{Id=4, Nombre="Samsung Galaxy", Precio=450000},
                new Producto{Id=5, Nombre="Cortana", Precio=500000},
            };

            carrito = new List<Producto>();

            
        }
        
        ///READ

        public IEnumerable<Producto> GetAll()
        {
            return productos;
        }

        
        //CREATE ADD
        public Producto AddToCarrito(Producto productoItem)
        {
            productoItem.Id = carrito.Max(r => r.Id) + 1;
            carrito.Add(productoItem);
            return productoItem;
        }



    }
}