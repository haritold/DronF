using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Drone.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Drone.App.Persistencia
{
    public class RepositorioPedido:IRepositorioPedido
    {

        List<Producto> inventario;
        List<Producto> carrito;
        Cliente cliente;

        ///------------------------------------------------

        /// <summary>
        /// </summary>

        private readonly AppContext _appContext;

        /// <summary>
        /// </summary>
        /// <param name="appContext"></param>

        /// APPCONTEXT
        public RepositorioPedido(AppContext appContext)
        {
            _appContext = appContext;

            inventario = new List<Producto>()
            {
                new Producto{Id=1, Nombre="Libro- Autofact", Precio=35000},
                new Producto{Id=2, Nombre="HardDrive- Kingston 1Th", Precio=450000},
                new Producto{Id=3, Nombre="BT Speaker", Precio=250000},
                new Producto{Id=4, Nombre="Samsung Galaxy", Precio=450000},
                new Producto{Id=5, Nombre="Cortana", Precio=500000},
            };

            carrito = new List<Producto>()
            {
                new Producto{Id=0, Nombre="Prueba", Precio=1000}     
            };

            cliente = new Cliente();

        }
        
    

        /// CREATE- ADD
        public Pedido AddPedido(Pedido pedido)
        {
            var pedidoInsertado = _appContext.Pedidos.Add(pedido);
            _appContext.SaveChanges();
            return pedidoInsertado.Entity;
        }

        /// READ
        
        public IEnumerable<Pedido> GetAllPedidos()
        {
            return _appContext.Pedidos;
        }

        public Pedido GetPedido (int pedidoId)
        {
            return _appContext.Pedidos.SingleOrDefault(p =>p.Id ==pedidoId);
        }

        public IEnumerable<Producto> GetProductosPedido(int idPedido)
        {
            var pedido = _appContext.Pedidos.Where(p => p.Id == idPedido)
                                    .Include(p => p.Productos)
                                    .FirstOrDefault();
            return pedido.Productos;
        }

        /// DELETE

        public void DeletePedido(int idPedido)
        {
            var pedidoEncontrado = _appContext.Pedidos.FirstOrDefault(p => p.Id == idPedido);
            if(pedidoEncontrado == null)
            return;
            _appContext.Pedidos.Remove(pedidoEncontrado);
            _appContext.SaveChanges();
        }


        /// ASIGN- UPDATE

        public Cliente AsignarCliente(int idPedido, int idCliente)
        {
            var pedidoEncontrado = _appContext.Pedidos.FirstOrDefault(p => p.Id == idPedido);
            if(pedidoEncontrado != null)
            {
                var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == idCliente);
                if(clienteEncontrado != null)
                {
                    pedidoEncontrado.ClienteF = clienteEncontrado;
                    _appContext.SaveChanges();
                }
                return clienteEncontrado;
            }
            return null;

        }

        public Encargado AsignarEncargado(int idPedido, int idEncargado )
        {
            var pedidoEncontrado = _appContext.Pedidos.FirstOrDefault(p => p.Id == idPedido);
            if(pedidoEncontrado != null)
            {
                var encargadoEncontrado = _appContext.Encargados.FirstOrDefault(e => e.Id == idEncargado);
                if(encargadoEncontrado != null)
                {
                    pedidoEncontrado.EncargadoF = encargadoEncontrado;
                    _appContext.SaveChanges();
                }
                return encargadoEncontrado;
            }
            return null;

        }


        ///PSEUDODATABASE METHODS
        public IEnumerable<Producto> GetAllInventario()
        {
            return inventario;
        }

        public Producto AddToCarrito(Producto pedidoItem)
        {
            // pedidoItem.Id = carrito.Max(r => r.Id) + 1;
            carrito.Add(pedidoItem);
            return pedidoItem;
        }

        public IEnumerable<Producto> GetAllCarrito()
        {
            return carrito;
        }

        public Producto GetProductoPorId(int productoId)
        {
            return inventario.SingleOrDefault(p => p.Id == productoId);
        }

    }
}