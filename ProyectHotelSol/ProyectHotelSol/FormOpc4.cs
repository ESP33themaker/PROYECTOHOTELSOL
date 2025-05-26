using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectHotelSol
{
    public partial class FormOpc4 : Form
    {
        public FormOpc4()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FormMP menuPrincipal = new FormMP();
            menuPrincipal.Show();
            this.Close();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = ConexionBD1.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM Factura";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    DgvFacturas.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar facturas: " + ex.Message);
                }
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            string idFacturaTexto = TbFactura.Text.Trim();

            if (!int.TryParse(idFacturaTexto, out int idFactura))
            {
                MessageBox.Show("Ingrese un ID de factura válido.");
                return;
            }

            using (MySqlConnection conexion = ConexionBD1.ObtenerConexion())
            {
                try
                {
                    conexion.Open();

                    // Consultar factura
                    string consultaFactura = "SELECT * FROM Factura WHERE Id = @id";
                    MySqlCommand cmdFactura = new MySqlCommand(consultaFactura, conexion);
                    cmdFactura.Parameters.AddWithValue("@id", idFactura);

                    MySqlDataReader readerFactura = cmdFactura.ExecuteReader();

                    if (!readerFactura.Read())
                    {
                        MessageBox.Show("No se encontró ninguna factura con ese ID.");
                        return;
                    }

                    int idCliente = readerFactura.GetInt32("id_cliente");
                    int idReserva = readerFactura.GetInt32("id_reserva");
                    string estadoFactura = readerFactura.GetString("Estado_factura");
                    readerFactura.Close();

                    // Consultar cliente
                    string consultaCliente = "SELECT * FROM Cliente WHERE Id = @id";
                    MySqlCommand cmdCliente = new MySqlCommand(consultaCliente, conexion);
                    cmdCliente.Parameters.AddWithValue("@id", idCliente);

                    MySqlDataReader readerCliente = cmdCliente.ExecuteReader();
                    string datosCliente = "";
                    if (readerCliente.Read())
                    {
                        datosCliente = $"Nombre: {readerCliente["Nombre"]} {readerCliente["Ap_pat"]} {readerCliente["Ap_mat"]}\n" +
                                       $"Documento: {readerCliente["Documento_identificacion"]}\n" +
                                       $"RFC: {readerCliente["RFC"]}";
                    }
                    readerCliente.Close();

                    // Consultar reserva
                    string consultaReserva = "SELECT * FROM Reserva WHERE Id = @id";
                    MySqlCommand cmdReserva = new MySqlCommand(consultaReserva, conexion);
                    cmdReserva.Parameters.AddWithValue("@id", idReserva);

                    MySqlDataReader readerReserva = cmdReserva.ExecuteReader();
                    string datosReserva = "";
                    if (readerReserva.Read())
                    {
                        datosReserva = $"Adultos: {readerReserva["Adultos_hospedar"]}\n" +
                                       $"Niños: {readerReserva["Ninos_hospedar"]}\n" +
                                       $"Estado Llaves: {((bool)readerReserva["Estado_Llaves"] ? "Entregadas" : "No entregadas")}\n" +
                                       $"Estado Pago: {readerReserva["Estado_pago"]}\n" +
                                       $"Fecha Ingreso: {readerReserva["Fecha_ingreso"]}\n" +
                                       $"Fecha Salida: {readerReserva["Fecha_salida"]}\n" +
                                       $"IVA: {readerReserva["IVA"]}\n" +
                                       $"Subtotal: {readerReserva["Subtotal"]}\n" +
                                       $"Total: {readerReserva["Total"]}";
                    }
                    readerReserva.Close();

                    // Crear archivo .txt
                    string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Factura_" + idFactura + ".txt");

                    using (StreamWriter writer = new StreamWriter(ruta))
                    {
                        writer.WriteLine("********** FACTURA ELECTRÓNICA **********");
                        writer.WriteLine("               HOTEL SOL               ");
                        writer.WriteLine("****************************************");
                        writer.WriteLine("\n>> DATOS DE LA FACTURA:");
                        writer.WriteLine($"ID Factura: {idFactura}");
                        writer.WriteLine($"Estado: {estadoFactura}");

                        writer.WriteLine("\n>> DATOS DEL CLIENTE:");
                        writer.WriteLine(datosCliente);

                        writer.WriteLine("\n>> DATOS DE LA RESERVA:");
                        writer.WriteLine(datosReserva);

                        writer.WriteLine("\n****************************************");
                        writer.WriteLine("Gracias por su preferencia.");
                    }

                    MessageBox.Show("Factura generada con éxito en el escritorio.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar la factura: " + ex.Message);
                }
            }
        }
    }
}
