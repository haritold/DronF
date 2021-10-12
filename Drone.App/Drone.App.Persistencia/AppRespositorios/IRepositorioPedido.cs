using System.Collections.Generic;
using System.Linq;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public interface IRepositorioPedido
    {
        Pedido AddPedido (Pedido nuevoPedido);

        IEnumerable<Pedido> GetAll();

        Pedido GetPedidoPorId (int pedidoId);
    }
}