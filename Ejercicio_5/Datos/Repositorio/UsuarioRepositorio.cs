using Dapper;
using Datos.Interfaces;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private string CadenaConexion;

        public UsuarioRepositorio(string _cadenaconexion)
        {
            CadenaConexion = _cadenaconexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }


        public Task<bool> Actualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetLista()
        {
            throw new NotImplementedException();
        }

       

        public Task<bool> Nuevo(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> GetPorCodigo(string codigo)
        {
            Usuario user = new Usuario();
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "SELECT * FROM usuario WHERE Codigo = @Codigo;";
                user = await conexion.QueryFirstAsync<Usuario>(sql, new { codigo });
            }
            catch (Exception)
            {
            }
            return user;
        }
    }
}
