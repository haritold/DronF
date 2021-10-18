using System.Linq;
using Drone.App.Dominio;
using System.Collections.Generic;

namespace Drone.App.Persistencia
{
    public class RepositorioEncargado:IRepositorioEncargado
    {
         /// <summary>
        /// </summary>

        private readonly AppContext _appContext;

        /// <summary>
        /// </summary>
        /// <param name="appContext"></param>

        public RepositorioEncargado(AppContext appContext)
        {
            _appContext = appContext;
        }


        ///CREATE

        public Encargado Add(Encargado encargado)
        {
            var encargadoInsertado = _appContext.Encargados.Add(encargado);
            _appContext.SaveChanges();
            return encargadoInsertado.Entity;
        }

        ///READ (get by id, getall)

        public Encargado GetEncargadoPorId(int encargadoId)
        {
            return _appContext.Encargados.SingleOrDefault(e => e.Id == encargadoId);
        }

        public IEnumerable<Encargado> GetAll()
        {
            return _appContext.Encargados;
        }

        ///UPDATE

        public Encargado Update(Encargado encargadoActualizado)
        {
            var encargado = _appContext.Encargados.SingleOrDefault(r => r.Id == encargadoActualizado.Id);
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
                
                _appContext.SaveChanges();
            }
            return encargado;
        }


    }
}

        ///PSEUDO DATABASE

        // List<Encargado> encargados;

        // public RepositorioEncargado()
        // {
        //     encargados = new List<Encargado>()
        //     {
        //         new Encargado{ Id= 1, Nombre="Pablo", Apellido="Jaramillo", Cedula="75413624", Telefono= "3145234038", Correo="pablo@gmail.com", Ciudad="Bogotá", PasswordEncarg="hagflsb2541Ñ" },
        //         new Encargado{ Id= 2, Nombre="Karen", Apellido="Rodriguez", Cedula="24156324", Telefono= "3178541236", Correo="karen@gmail.com", Ciudad="Bogotá", PasswordEncarg="jhalpo41Ñ" }
        //     };
        // }