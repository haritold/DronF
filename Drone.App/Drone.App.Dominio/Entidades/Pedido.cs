using System;

namespace Drone.App.Dominio
{
    public class Pedido
    {
        public int Id {get; set;}
        public System.Collections.Generic.List<Producto> Productos { get; set; }
        // public List<Producto> Productos {get; set;}

        public DateTime Fecha {get; set;}
        public string Satisfaccion {get; set;}
        public int Estrellas {get; set;}

        public Cliente ClienteF {get; set;}
        public Encargado EncargadoF {get; set;}
    }
}