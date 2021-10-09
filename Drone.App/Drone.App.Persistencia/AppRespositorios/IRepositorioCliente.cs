using System.Collections;
using System;
using System.Collections.Generic;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public interface IRepositorioCliente
    {
        Cliente AddCliente(Cliente nuevoCliente);

        Cliente GetClientePorId(int clienteId);

        IEnumerable<Cliente> GetAll();

        Cliente Update(Cliente clienteActualizado);

    }

}