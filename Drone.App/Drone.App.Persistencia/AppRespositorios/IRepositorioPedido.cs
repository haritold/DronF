using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public interface IRepositorioPedido
    {
        //READ
        Pedido GetPedido(int pedidoId);
        IEnumerable<Pedido> GetAllPedidos();

        Pedido AddPedido (Pedido nuevoPedido);
        // void AddProductosPedido(int idPedido);
        void DeletePedido(int idPedido);
        
        Cliente AsignarCliente(int idPedido, int idCliente);
        Encargado AsignarEncargado(int idPedido, int idEncargado );
        
        //PSEUDO DATABASE METHODS

        IEnumerable<Producto> GetAllInventario();

        Producto GetProductoPorId(int productoId);
        
        IEnumerable<Producto> GetAllCarrito();
        Producto AddToCarrito (Producto pedidoItem);

    }
}