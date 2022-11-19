using Datos.Interfaces;
using Datos.Repositorio;
using Ejercicio_5.Interfaces;
using Entidades;

namespace Ejercicio_5.Servicios
{
    public class LoginServicios : ILoginServicio
    {
        private readonly Config _configuracion;
        private ILoginRepositorio loginRepositorio;

        public LoginServicios(Config config)
        {
            _configuracion = config;
            loginRepositorio = new LoginRepositorio(config.CadenaConexion);

        }






        public async Task<bool> ValidarUsuario(Login login)
        {
            return await loginRepositorio.ValidarUsuario(login);
        }
    }
}
