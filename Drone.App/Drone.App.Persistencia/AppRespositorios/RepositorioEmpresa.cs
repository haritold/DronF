using Drone.App.Dominio;
using System.Linq;

namespace Drone.App.Persistencia
{
    public class RepositorioEmpresa :IRepositorioEmpresa
    {
        /// <summary>
        /// </summary>

        private readonly AppContext _appContext;

        /// <summary>
        /// </summary>
        /// <param name="appContext"></param>

        public RepositorioEmpresa(AppContext appContext)
        {
            _appContext = appContext;
        }

        ///READ
        public Empresa GetEmpresaPorUser(string usuarioEmpresa)
        {
            return _appContext.Empresas.SingleOrDefault(e => e.RazonSocial == usuarioEmpresa);
        }

        public Empresa GetEmpresaPorPass(string passwordEmpresa)
        {
            return _appContext.Empresas.SingleOrDefault(e => e.PasswordEmp == passwordEmpresa);
        }




    }
}