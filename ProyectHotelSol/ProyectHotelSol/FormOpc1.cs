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
    public partial class FormOpc1 : Form
    {
        public FormOpc1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MostrarHabitacionesPorTipo(string tipoHabitacion)
        {
            LbLibre.Items.Clear();
            LbOcupada.Items.Clear();

            int libres = 0;
            int ocupadas = 0;

            try
            {
                MySqlConnection conn = ConexionBD.AbrirConexion();
                string query = "SELECT Nm_habitacion, Estado FROM Habitacion WHERE Tipo = @tipo";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tipo", tipoHabitacion);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int numHabitacion = reader.GetInt32("Nm_habitacion");
                    string estado = reader.GetString("Estado");

                    if (estado == "Libre")
                    {
                        LbLibre.Items.Add(numHabitacion);
                        libres++;
                    }
                    else if (estado == "Ocupada")
                    {
                        LbOcupada.Items.Add(numHabitacion);
                        ocupadas++;
                    }
                }

                reader.Close();
                ConexionBD.CerrarConexion(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar habitaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TbNmLibres.Text = libres.ToString();
            TbNmOcupadas.Text = ocupadas.ToString();
        }


        private void BtnHSencillo_Click(object sender, EventArgs e)
        {
            MostrarHabitacionesPorTipo("Sencillo");
        }

        private void BtnHDoble_Click(object sender, EventArgs e)
        {
            MostrarHabitacionesPorTipo("Doble");
        }

        private void BtnHSuite_Click(object sender, EventArgs e)
        {
            MostrarHabitacionesPorTipo("Suite");
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FormMP menuPrincipal = new FormMP();
            menuPrincipal.Show();
            this.Close();
        }
    }
}
