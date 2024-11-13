using Clave_Grupo2.Clases;
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

namespace Clave_Grupo2
{
    public partial class Form3 : Form
    {

        private Vuelo vuelo;
        private Reserva reserva;
        public Form3(Reserva reservaActual,Vuelo vueloSeleccionado)
        {
            InitializeComponent();
             reserva = reservaActual;
            vuelo = vueloSeleccionado;
            
            lblOrogen.Text = vuelo.Origen;
            lblDestino2.Text = vuelo.Destino;
            lblHora.Text += vuelo.HoraSalida;
            lblCantidad.Text += Convert.ToString(reserva.Asientos);
            lblSubtotal.Text += Convert.ToString(reserva.Asientos * vuelo.Precio);
        }

        /// <summary>
        /// Evento se desencadena cuando se preciona el boton PAgar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPagar_Click(object sender, EventArgs e)
        {
            double subtotal = vuelo.Precio * reserva.Asientos;

            Pago pago = new Pago();
            pago.IDPago = reserva.IdPago;
            pago.MetodoPago = cboxPago.Text;
            pago.Subtotal = subtotal;
            if(cboxEquipaje.SelectedIndex == 0) { pago.Recargo = 0; }
            else if (cboxEquipaje.SelectedIndex == 1) { pago.Recargo = 0.1; }
            else { pago.Recargo = 0.2; }
            pago.Total = subtotal + subtotal * pago.Recargo;
            

            
            
            string consulta = $"INSERT INTO pago (idPago, metodoPago, subtotal, recargo, Total) VALUES ({pago.IDPago}, '{pago.MetodoPago}', '{pago.Subtotal}', {pago.Recargo}, {pago.Total})";
            
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                try
                {


                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener los vuelos: " + ex.Message);
                }
                finally
                {
                    ConexionBD.CerrarConexion(conexion);
                }
            }

            string fechaReservaStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            int tinyInt = reserva.Cancelada ? 1 : 0;
            string consulta2 = $"INSERT INTO reserva (idReserva, nombre, fechaReserva, asientos, cacelada, idVuelo, idPago) VALUES ({reserva.IDReserva}, '{reserva.Nombre}', '{fechaReservaStr}', {reserva.Asientos}, {tinyInt},{reserva.IdVuelo}, {reserva.IdPago})";
            
            using (MySqlConnection conexion2 = ConexionBD.ObtenerConexion())
            {
                try
                {


                    MySqlCommand comando = new MySqlCommand(consulta2, conexion2);

                    
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar la db: " + ex.Message);
                }
                finally
                {
                    ConexionBD.CerrarConexion(conexion2);
                }
            }
            MessageBox.Show($"Tu reserva ha sido procesada con exito \nsete han cargado ${pago.Total} a tu cuenta de {pago.MetodoPago} \n ID de Reserva: {pago.IDPago}");
            Close();

        }
    }
}
