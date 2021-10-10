using System.Collections.Generic;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public interface IRepositorioProducto
    {
        

        IEnumerable<Producto> GetAll();

       
    }
}