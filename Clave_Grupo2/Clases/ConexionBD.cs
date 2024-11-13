using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave_Grupo2.Clases
{
    /// <summary>
    /// Clase para conectarse a la base de datos
    /// </summary>
    public class ConexionBD
    {
        private static string servidor = "localhost"; //Nombre o ip del servidor de MySQL
        private static string bd = "clave2_grupo2db"; //Nombre de la base de datos
        private static string usuario = "root"; //Usuario de acceso a MySQL
        private static string password = "root"; //Contraseña de usuario de acceso a MySQL
        public static MySqlConnection ObtenerConexion()
        {
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor +
            "; User Id=" + usuario + "; Password=" + password +
           "";
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();
            return conexionBD;
        }
        public static void CerrarConexion(MySqlConnection conexionBD)
        {
            conexionBD.Close();
        }
    }
}
