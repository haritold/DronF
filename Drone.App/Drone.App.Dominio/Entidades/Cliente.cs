using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;

namespace Drone.App.Dominio
{
    public class Cliente
    {
        public int Id {get; set;}

        [Required, StringLength(35)]
        public string Nombre {get; set;}

        [Required, StringLength(35)]
        public string Apellido {get; set;}

        [Required, StringLength(10)]
        public string Cedula {get; set;}

        [Required, StringLength(10)]
        public string Telefono {get; set;}

        [Required, StringLength(50)]
        public string Correo {get; set;}

        [Required, StringLength(35)]
        public string Direccion {get; set;}

        [Required, StringLength(10)]
        public string PasswordClie {get; set;}
    }
}