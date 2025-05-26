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
    public partial class FormOpc5 : Form
    {
        public FormOpc5()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMP menuPrincipal = new FormMP();
            menuPrincipal.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TbBuscar.Text);

                using (MySqlConnection conexion = ConexionBD1.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "SELECT Nombre, Ap_pat, Ap_mat, Tipo, Contraseña FROM Usuario WHERE Id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TbNombre.Text = reader.GetString("Nombre");
                                TbAp.Text = reader.GetString("Ap_pat");
                                TbAm.Text = reader.GetString("Ap_mat");
                                TbTipo.Text = reader.GetString("Tipo");
                                TbContra.Text = reader.GetString("Contraseña"); // Muestra encriptada porque no se puede desencriptar SHA256
                            }
                            else
                            {
                                MessageBox.Show("Usuario no encontrado.");
                            }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = TbNombre.Text;
                string apPat = TbAp.Text;
                string apMat = TbAm.Text;
                string tipo = TbTipo.Text;
                string contra = TbContra.Text;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apPat) ||
                    string.IsNullOrWhiteSpace(apMat) || string.IsNullOrWhiteSpace(tipo) ||
                    string.IsNullOrWhiteSpace(contra))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                string contraEncriptada = Seguridad.EncriptarSHA256(contra);

                using (MySqlConnection conexion = ConexionBD1.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "INSERT INTO Usuario (Nombre, Ap_pat, Ap_mat, Tipo, Contraseña) VALUES (@nombre, @apPat, @apMat, @tipo, @contra)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apPat", apPat);
                        cmd.Parameters.AddWithValue("@apMat", apMat);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@contra", contraEncriptada);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario creado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TbBuscar.Text);
                string nombre = TbNombre.Text;
                string apPat = TbAp.Text;
                string apMat = TbAm.Text;
                string tipo = TbTipo.Text;
                string contra = TbContra.Text;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apPat) ||
                    string.IsNullOrWhiteSpace(apMat) || string.IsNullOrWhiteSpace(tipo) ||
                    string.IsNullOrWhiteSpace(contra))
                {
                    MessageBox.Show("Todos los campos deben estar completos.");
                    return;
                }

                string contraEncriptada = Seguridad.EncriptarSHA256(contra);

                using (MySqlConnection conexion = ConexionBD1.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "UPDATE Usuario SET Nombre = @nombre, Ap_pat = @apPat, Ap_mat = @apMat, Tipo = @tipo, Contraseña = @contra WHERE Id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apPat", apPat);
                        cmd.Parameters.AddWithValue("@apMat", apMat);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@contra", contraEncriptada);
                        cmd.Parameters.AddWithValue("@id", id);

                        int filas = cmd.ExecuteNonQuery();
                        if (filas > 0)
                            MessageBox.Show("Usuario actualizado correctamente.");
                        else
                            MessageBox.Show("Usuario no encontrado.");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TbEliminar.Text);

                using (MySqlConnection conexion = ConexionBD1.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "DELETE FROM Usuario WHERE Id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int filas = cmd.ExecuteNonQuery();
                        if (filas > 0)
                            MessageBox.Show("Usuario eliminado correctamente.");
                        else
                            MessageBox.Show("Usuario no encontrado.");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            } 
             
             


        }
    }
}
