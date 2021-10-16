using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public interface IRepositorioEmpresa
    {
        Empresa GetEmpresaPorUser(string usuarioEmpresa);

        Empresa GetEmpresaPorPass(string passwordEmpresa);
    }
}