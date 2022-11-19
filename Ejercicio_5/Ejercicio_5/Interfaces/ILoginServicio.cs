using Entidades;

namespace Ejercicio_5.Interfaces
{
    public interface ILoginServicio
    {
        Task<bool> ValidarUsuario(Login login);
    }
}
