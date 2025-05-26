using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectHotelSol
{
    internal class ConexionBD
    {
        private static string cadenaConexion = "server=localhost;user=root;password=12345;database=HotelSol;";
        private static MySqlConnection conexion = null;

        // Método para abrir la conexión
        public static MySqlConnection AbrirConexion()
        {
            if (conexion == null)
                conexion = new MySqlConnection(cadenaConexion);

            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }

        // Método para cerrar la conexión
        public static void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }

}
