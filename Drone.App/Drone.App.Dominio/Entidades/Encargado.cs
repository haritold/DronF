using System;
using System.ComponentModel.DataAnnotations;

namespace Drone.App.Dominio
{
    public class Encargado
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

        [Required, StringLength(20)]
        public string Ciudad {get; set;}

        [Required, StringLength(12)]
        public string PasswordEncarg{get; set;}

    }
}