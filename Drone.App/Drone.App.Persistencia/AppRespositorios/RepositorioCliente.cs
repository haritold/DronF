using System.Collections.Generic;
using System.Linq;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public class RepositorioCliente :IRepositorioCliente
    {

        /// <summary>
        /// </summary>

        private readonly AppContext _appContext;

        /// <summary>
        /// </summary>
        /// <param name="appContext"></param>

        public RepositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }

        /// CREATE

        public Cliente AddCliente(Cliente cliente)
        {
            var clienteInsertado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteInsertado.Entity;
        }

        /// READ
        
        public IEnumerable<Cliente> GetAll()
        {
            return _appContext.Clientes;
        }

        public Cliente  GetClientePorId(int clienteId)
        {
            return _appContext.Clientes.SingleOrDefault(c => c.Id == clienteId);
        }

        public Cliente GetClientePorCedula(string cedulaCliente)
        {
            return _appContext.Clientes.SingleOrDefault(c => c.Cedula == cedulaCliente );
        }

        public Cliente GetClientePorPass(string passwordCliente)
        {
            return _appContext.Clientes.SingleOrDefault(c => c.PasswordClie == passwordCliente);
        }

        public int GetClienteId(string cedulaCliente)
        {
            var clienteEn = _appContext.Clientes.SingleOrDefault(c => c.Cedula == cedulaCliente);
            return clienteEn.Id;
        }

        ///UPDATE

        public Cliente Update(Cliente clienteActualizado)
        {
            var cliente = _appContext.Clientes.SingleOrDefault(r => r.Id == clienteActualizado.Id);
            if(cliente!=null)
            {
                cliente.Nombre = clienteActualizado.Nombre;
                cliente.Apellido = clienteActualizado.Apellido;
                cliente.Cedula = clienteActualizado.Cedula;
                cliente.Telefono = clienteActualizado.Telefono;
                cliente.Correo = clienteActualizado.Correo;
                cliente.Direccion = clienteActualizado.Direccion;
                cliente.PasswordClie = clienteActualizado.PasswordClie;

                _appContext.SaveChanges();
                
            }
            return cliente;
        }

    }
}


///---------------------------------------
        ///PSEUDO DATABASE

        // List<Cliente> clientes;

        // public RepositorioCliente()
        // {
        //     clientes = new List<Cliente>()
        //     {
        //         new Cliente {Id= 1, Nombre= "Andres", Apellido= "Parra", Cedula= "75841236", Telefono= "312453614", Correo= "andres@gmail.com", Direccion= "Calle 5", PasswordClie= "shgdlsbd541" },
        //         new Cliente {Id= 2, Nombre= "Anamaria", Apellido="Carvajal", Cedula= "24156324", Telefono= "314785123", Correo= "anamaria@gmail.com", Direccion= "Avenida 12", PasswordClie= "KJABDJHSW55" }
        //     };
        // }

        // public IEnumerable<Cliente> GetAll()
        // {
        //     return clientes;
        // }

        ///---------------------------------------