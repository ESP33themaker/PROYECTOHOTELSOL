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
    public partial class FormOpc3 : Form
    {
        public FormOpc3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroHabitacion;

            // Validación de entrada: número de habitación válido
            if (!int.TryParse(TbNh.Text.Trim(), out numeroHabitacion))
            {
                MessageBox.Show("Por favor ingrese un número de habitación válido.");
                return;
            }

            using (MySqlConnection conexion = ConexionBD1.ObtenerConexion())
            {
                try
                {
                    conexion.Open();

                    // 1. Verificar si la habitación existe y está ocupada
                    string consultaEstado = "SELECT Estado FROM Habitacion WHERE Nm_habitacion = @num";
                    using (MySqlCommand cmd = new MySqlCommand(consultaEstado, conexion))
                    {
                        cmd.Parameters.AddWithValue("@num", numeroHabitacion);
                        object estadoObj = cmd.ExecuteScalar();

                        if (estadoObj == null)
                        {
                            MessageBox.Show("La habitación no existe.");
                            return;
                        }

                        string estado = estadoObj.ToString();
                        if (estado == "Libre")
                        {
                            MessageBox.Show("La habitación ya está libre. Ingrese una habitación ocupada.");
                            return;
                        }
                    }

                    // 2. Obtener la última reserva de esa habitación
                    int idReserva = -1, idCliente = -1;
                    string consultaReserva = @"
                SELECT Id, id_cliente FROM Reserva 
                WHERE id_habitacion = @num 
                ORDER BY Id DESC LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(consultaReserva, conexion))
                    {
                        cmd.Parameters.AddWithValue("@num", numeroHabitacion);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idReserva = reader.GetInt32("Id");
                                idCliente = reader.GetInt32("id_cliente");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró una reserva para esta habitación.");
                                return;
                            }
                        }
                    }

                    // 3. Validar datos de Llaves y Pago
                    string llaves = TbLlaves.Text.Trim().ToLower();
                    string pago = TbPago.Text.Trim().ToLower();
                    bool estadoLlaves;
                    string estadoPago;
                    string estadoFactura;

                    if (llaves == "si")
                        estadoLlaves = true;
                    else if (llaves == "no")
                        estadoLlaves = false;
                    else
                    {
                        MessageBox.Show("Valor inválido para entrega de llaves. Use 'Si' o 'No'.");
                        return;
                    }

                    if (pago == "si")
                    {
                        estadoPago = "Realizado";
                        estadoFactura = "Pagada";
                    }
                    else if (pago == "no")
                    {
                        estadoPago = "Pendiente";
                        estadoFactura = "Pendiente";
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido para estado de pago. Use 'Si' o 'No'.");
                        return;
                    }

                    // 4. Actualizar la reserva
                    string actualizarReserva = @"
                UPDATE Reserva SET 
                    Estado_Llaves = @llaves, 
                    Estado_pago = @pago 
                WHERE Id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(actualizarReserva, conexion))
                    {
                        cmd.Parameters.AddWithValue("@llaves", estadoLlaves);
                        cmd.Parameters.AddWithValue("@pago", estadoPago);
                        cmd.Parameters.AddWithValue("@id", idReserva);
                        cmd.ExecuteNonQuery();
                    }

                    // 5. Liberar la habitación
                    string liberarHabitacion = "UPDATE Habitacion SET Estado = 'Libre' WHERE Nm_habitacion = @num";
                    using (MySqlCommand cmd = new MySqlCommand(liberarHabitacion, conexion))
                    {
                        cmd.Parameters.AddWithValue("@num", numeroHabitacion);
                        cmd.ExecuteNonQuery();
                    }

                    // 6. Registrar factura
                    string insertarFactura = @"
                INSERT INTO Factura (Estado_factura, id_cliente, id_reserva) 
                VALUES (@estadoFactura, @idCliente, @idReserva)";
                    using (MySqlCommand cmd = new MySqlCommand(insertarFactura, conexion))
                    {
                        cmd.Parameters.AddWithValue("@estadoFactura", estadoFactura);
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.Parameters.AddWithValue("@idReserva", idReserva);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Habitación liberada y factura registrada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
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
