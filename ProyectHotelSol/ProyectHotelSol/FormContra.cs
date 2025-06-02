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

namespace ProyectHotelSol
{
    public partial class FormContra : Form
    {
        public FormContra()
        {
            InitializeComponent();
        }

        private void FormContra_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            string usuario = TbUsuario.Text.Trim();
            string contraseñaIngresada = TbContra.Text.Trim();
            string contraseñaEncriptada = Seguridad.EncriptarSHA256(contraseñaIngresada);

            try
            {
                MySqlConnection conexion = ConexionBD.AbrirConexion();

                string consulta = "SELECT Contraseña, Tipo FROM Usuario WHERE Nombre = @usuario";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string contraseñaBD = reader.GetString("Contraseña");
                    string tipoUsuario = reader.GetString("Tipo").ToLower();

                    if (contraseñaBD == contraseñaEncriptada)
                    {
                        if (tipoUsuario == "admin")
                        {
                            reader.Close(); // Cerramos el reader antes de abrir otra ventana
                            ConexionBD.CerrarConexion();

                            FormOpc5 opcionesAdmin = new FormOpc5();
                            opcionesAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            reader.Close();
                            ConexionBD.CerrarConexion();
                            MessageBox.Show("Solo un usuario de tipo 'admin' puede acceder.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        reader.Close();
                        ConexionBD.CerrarConexion();
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    reader.Close();
                    ConexionBD.CerrarConexion();
                    MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ConexionBD.CerrarConexion();
                MessageBox.Show("Error al verificar los datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FormMP menuPrincipal = new FormMP();
            menuPrincipal.Show();
            this.Close();
        }
    }
}
