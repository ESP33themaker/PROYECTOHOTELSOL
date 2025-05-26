using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectHotelSol
{
    internal class ConexionBD1
    {
        private static string cadenaConexion = "server=localhost;user=root;password=12345;database=HotelSol;";

        // Método para obtener una nueva conexión
        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}
