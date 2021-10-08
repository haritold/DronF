using System.Linq;
using Drone.App.Dominio;
using System.Collections.Generic;

namespace Drone.App.Persistencia
{
    public class RepositorioEncargado:IRepositorioEncargado
    {
        List<Encargado> encargados;

        public RepositorioEncargado()
        {
            encargados = new List<Encargado>()
            {
                new Encargado{ Id= 1, Nombre="Pablo", Apellido="Jaramillo", Cedula="75413624", Telefono= "3145234038", Correo="pablo@gmail.com", Ciudad="Bogotá", PasswordEncarg="hagflsb2541Ñ" },
                new Encargado{ Id= 2, Nombre="Karen", Apellido="Rodriguez", Cedula="24156324", Telefono= "3178541236", Correo="karen@gmail.com", Ciudad="Bogotá", PasswordEncarg="jhalpo41Ñ" }
            };
        }

        ///CREATE

        public Encargado Add(Encargado nuevoEncargado)
        {
            nuevoEncargado.Id = encargados.Max(r => r.Id) + 1;
            encargados.Add(nuevoEncargado);
            return nuevoEncargado;
        }

        ///READ (get by id, getall)

        public Encargado GetEncargadoPorId(int encargadoId)
        {
            return encargados.SingleOrDefault(e => e.Id == encargadoId);
        }

        public IEnumerable<Encargado> GetAll()
        {
            return encargados;
        }

        ///UPDATE

        public Encargado Update(Encargado encargadoActualizado)
        {
            var encargado = encargados.SingleOrDefault(r => r.Id == encargadoActualizado.Id);
            if(encargado!=null)
            {
                encargado.Nombre = encargadoActualizado.Nombre;
                encargado.Apellido = encargadoActualizado.Apellido;
                encargado.Cedula = encargadoActualizado.Cedula;
                encargado.Nombre = encargadoActualizado.Nombre;
                encargado.Telefono = encargadoActualizado.Telefono;
                encargado.Correo = encargadoActualizado.Correo;
                encargado.Ciudad = encargadoActualizado.Ciudad;
                encargado.PasswordEncarg = encargadoActualizado.PasswordEncarg;
                
            }
            return encargado;
        }


    }
}