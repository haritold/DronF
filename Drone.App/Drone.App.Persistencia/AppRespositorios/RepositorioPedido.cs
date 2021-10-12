using System.Collections.Generic;
using System.Linq;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public class RepositorioPedido:IRepositorioPedido
    {
        /// <summary>
        /// </summary>

        private readonly AppContext _appContext;

        /// <summary>
        /// </summary>
        /// <param name="appContext"></param>

        public RepositorioPedido(AppContext appContext)
        {
            _appContext = appContext;
        }

        /// CREATE

        public Pedido AddPedido(Pedido pedido)
        {
            var pedidoInsertado = _appContext.Pedidos.Add(pedido);
            _appContext.SaveChanges();
            return pedidoInsertado.Entity;
        }

        /// READ
        
        public IEnumerable<Pedido> GetAll()
        {
            return _appContext.Pedidos;
        }

        public Pedido GetPedidoPorId (int pedidoId)
        {
            return _appContext.Pedidos.SingleOrDefault(p =>p.Id ==pedidoId);
        }



    }
}