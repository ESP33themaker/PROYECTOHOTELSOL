using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ProyectHotelSol
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = TbUsuario.Text.Trim();
            string contraseñaIngresada = TbContraseña.Text.Trim();
            string contraseñaEncriptada = Seguridad.EncriptarSHA256(contraseñaIngresada);

            try
            {
                MySqlConnection conexion = ConexionBD.AbrirConexion();

                string consulta = "SELECT Contraseña FROM Usuario WHERE Nombre = @usuario";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                object resultado = cmd.ExecuteScalar();

                if (resultado == null)
                {
                    MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string contraseñaBD = resultado.ToString();

                    if (contraseñaBD == contraseñaEncriptada)
                    {
                        FormMP menuPrincipal = new FormMP();
                        menuPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                ConexionBD.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
