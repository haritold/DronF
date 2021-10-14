using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public interface IRepositorioPedido
    {
        IEnumerable<Pedido> GetAllPedidos();
        Pedido AddPedido (Pedido nuevoPedido);
        void DeletePedido(int idPedido);
        Pedido GetPedido(int pedidoId);
        Cliente AsignarCliente(int idPedido, int idCliente);
        Encargado AsignarEncargado(int idPedido, int idEncargado );
        IEnumerable<Producto> GetProductosPedido(int idPedido);


        //PSEUDO DATABASE METHODS

        IEnumerable<Producto> GetAllInventario();

    }
}