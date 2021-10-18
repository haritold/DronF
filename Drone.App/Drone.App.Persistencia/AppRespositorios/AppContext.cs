using Microsoft.EntityFrameworkCore;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public class AppContext : DbContext
    {

        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Encargado> Encargados {get; set;}
        public DbSet<Pedido> Pedidos {get; set;}
        public DbSet<Producto> Productos {get; set;}
        public DbSet<Estado> Estados {get; set;}
        public DbSet<Empresa> Empresas {get; set;}

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            if(!optionsBuilder.IsConfigured){

                optionsBuilder
                .UseSqlServer("Server=tcp:dronef.database.windows.net,1433;Initial Catalog=DroneDataBase;Persist Security Info=False;User ID=dronef;Password=turingsoftware1.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
                //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DroneDataBase");
            }

        }


    }
}