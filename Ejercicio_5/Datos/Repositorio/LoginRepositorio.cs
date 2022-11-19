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
    public class LoginRepositorio : ILoginRepositorio
    {
        private string CadenaConexion;
        


        public LoginRepositorio(string _cadenaconexion)
        {
            CadenaConexion = _cadenaconexion;
        }
        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }


        public async Task<bool> ValidarUsuario(Login login)
        {
            bool valido = false;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "SELECT 1 FROM usuario WHERE Codigo = @Codigo AND Clave = @Clave;";
                valido = await conexion.ExecuteScalarAsync<bool>(sql, new { login.Codigo, login.Clave });
            }
            catch (Exception)
            {
            }
            return valido;
        }


       







    }
}
