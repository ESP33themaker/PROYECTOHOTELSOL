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
    public partial class FormOpc2 : Form
    {
        public FormOpc2()
        {
            InitializeComponent();
        }

        private void FormOpc2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistroC_Click(object sender, EventArgs e)
        {
            string nombre = TbCNombre.Text.Trim();
            string apPat = TbCAp.Text.Trim();
            string apMat = TbCAm.Text.Trim();
            string documento = TbCIde.Text.Trim();
            string rfc = TbCRFC.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apPat) || string.IsNullOrEmpty(apMat) ||
                string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(rfc))
            {
                MessageBox.Show("Por favor llena todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = ConexionBD1.ObtenerConexion())
                {
                    conn.Open();

                    string query = "INSERT INTO Cliente (Nombre, Ap_pat, Ap_mat, Documento_identificacion, RFC) " +
                                   "VALUES (@Nombre, @Ap_pat, @Ap_mat, @Documento_identificacion, @RFC)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Ap_pat", apPat);
                        cmd.Parameters.AddWithValue("@Ap_mat", apMat);
                        cmd.Parameters.AddWithValue("@Documento_identificacion", documento);
                        cmd.Parameters.AddWithValue("@RFC", rfc);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActDgv_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = ConexionBD1.ObtenerConexion())
                {
                    conn.Open();

                    string query = "SELECT * FROM Cliente";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DgvClientes.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(TbHNm.Text.Trim(), out int numeroHabitacion))
                {
                    MessageBox.Show("Por favor, ingresa un número de habitación válido.");
                    return;
                }

                using (MySqlConnection conexion = ConexionBD1.ObtenerConexion())
                {
                    conexion.Open();

                    // Verificar estado
                    string consultaEstado = "SELECT Estado FROM Habitacion WHERE Nm_habitacion = @Nm";
                    using (MySqlCommand comandoEstado = new MySqlCommand(consultaEstado, conexion))
                    {
                        comandoEstado.Parameters.AddWithValue("@Nm", numeroHabitacion);
                        object estadoObj = comandoEstado.ExecuteScalar();

                        if (estadoObj == null)
                        {
                            MessageBox.Show("La habitación no existe en la base de datos.");
                            return;
                        }

                        string estado = estadoObj.ToString();

                        if (estado == "Ocupada")
                        {
                            MessageBox.Show("La habitación está ocupada.");
                            return;
                        }
                    }

                    // Consultar datos
                    string consultaDatos = "SELECT Tipo, Tarifa FROM Habitacion WHERE Nm_habitacion = @Nm";
                    using (MySqlCommand comandoDatos = new MySqlCommand(consultaDatos, conexion))
                    {
                        comandoDatos.Parameters.AddWithValue("@Nm", numeroHabitacion);
                        using (MySqlDataReader reader = comandoDatos.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string tipo = reader.GetString("Tipo");
                                int tarifa = reader.GetInt32("Tarifa");

                                LblHTipo.Text = tipo;
                                LblHTarifa.Text = tarifa.ToString();
                                LblRHab.Text = numeroHabitacion.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron los datos de la habitación.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la habitación: " + ex.Message);
            }
        }

        private void BtnCrearReservacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (!int.TryParse(TbRAdultos.Text.Trim(), out int adultos))
                {
                    MessageBox.Show("Número de adultos inválido.");
                    return;
                }

                if (!int.TryParse(TbRNinos.Text.Trim(), out int ninos))
                {
                    MessageBox.Show("Número de niños inválido.");
                    return;
                }

                if (!int.TryParse(TbRCliente.Text.Trim(), out int idCliente))
                {
                    MessageBox.Show("ID del cliente inválido.");
                    return;
                }

                if (!int.TryParse(TbRUsuario.Text.Trim(), out int idUsuario))
                {
                    MessageBox.Show("ID del usuario inválido.");
                    return;
                }

                if (!int.TryParse(LblRHab.Text.Trim(), out int idHabitacion))
                {
                    MessageBox.Show("Número de habitación inválido.");
                    return;
                }

                if (!int.TryParse(LblHTarifa.Text.Trim(), out int tarifa))
                {
                    MessageBox.Show("Tarifa inválida.");
                    return;
                }

                // Fechas
                DateTime fechaIngreso = DtpIngreso.Value.Date;
                DateTime fechaSalida = DtpSalida.Value.Date;

                if (fechaSalida <= fechaIngreso)
                {
                    MessageBox.Show("La fecha de salida debe ser posterior a la de ingreso.");
                    return;
                }

                // Cálculos
                int dias = (fechaSalida - fechaIngreso).Days;
                int subtotal = dias * tarifa;
                int iva = (int)(subtotal * 0.16);
                int total = subtotal + iva;

                // Mostrar en etiquetas
                LblSub.Text = subtotal.ToString();
                Lbliva.Text = iva.ToString();
                LblTot.Text = total.ToString();

                // Conexión
                using (MySqlConnection conn = ConexionBD1.ObtenerConexion())
                {
                    conn.Open();

                    // Insertar nueva reserva
                    string insertReserva = "INSERT INTO Reserva (Adultos_hospedar, Ninos_hospedar, Estado_Llaves, Estado_pago, " +
                                           "Fecha_ingreso, Fecha_salida, IVA, Subtotal, Total, id_cliente, id_habitacion, id_usuario) " +
                                           "VALUES (@Adultos, @Ninos, @Llaves, @Pago, @Ingreso, @Salida, @IVA, @Subtotal, @Total, @Cliente, @Habitacion, @Usuario)";
                    using (MySqlCommand cmd = new MySqlCommand(insertReserva, conn))
                    {
                        cmd.Parameters.AddWithValue("@Adultos", adultos);
                        cmd.Parameters.AddWithValue("@Ninos", ninos);
                        cmd.Parameters.AddWithValue("@Llaves", false);
                        cmd.Parameters.AddWithValue("@Pago", "Pendiente");
                        cmd.Parameters.AddWithValue("@Ingreso", fechaIngreso);
                        cmd.Parameters.AddWithValue("@Salida", fechaSalida);
                        cmd.Parameters.AddWithValue("@IVA", iva);
                        cmd.Parameters.AddWithValue("@Subtotal", subtotal);
                        cmd.Parameters.AddWithValue("@Total", total);
                        cmd.Parameters.AddWithValue("@Cliente", idCliente);
                        cmd.Parameters.AddWithValue("@Habitacion", idHabitacion);
                        cmd.Parameters.AddWithValue("@Usuario", idUsuario);

                        cmd.ExecuteNonQuery();
                    }

                    // Cambiar estado de la habitación a 'Ocupada'
                    string actualizarHabitacion = "UPDATE Habitacion SET Estado = 'Ocupada' WHERE Nm_habitacion = @Habitacion";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(actualizarHabitacion, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@Habitacion", idHabitacion);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Reserva registrada y habitación actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la reservación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
