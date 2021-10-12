using System.Collections;
using System.Collections.Generic;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public interface IRepositorioProducto
    {
        IEnumerable<Producto> GetAll();

        Producto AddToCarrito(Producto productoItem);

    }
}