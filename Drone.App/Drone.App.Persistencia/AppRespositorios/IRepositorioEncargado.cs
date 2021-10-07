using System.Net.NetworkInformation;
using System.Data;
using System.IO;
using System.Collections.Generic;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public interface IRepositorioEncargado
    {
        Encargado Add(Encargado nuevoEncargado);

        Encargado GetEncargadoPorId(int encargadoId);

        IEnumerable<Encargado> GetAll();

    }
}