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
    public partial class Form2 : Form
    {
        private Vuelo vueloSeleccionado;

        /// <summary>
        /// Inicializa los componentes del formulario
        /// </summary>
        /// <param name="vuelo"></param>
        public Form2(Vuelo vuelo)
        {
            InitializeComponent();

            //introducimos la informacion de nuestro objeto vuelo en los lbl cunado carge el formulario
            lblOrigen.Text = lblOrigen.Text + Convert.ToString(value: vuelo.Origen);
            lblDestino.Text = lblDestino.Text + Convert.ToString(value: vuelo.Destino);
            lblHoraPartida.Text = lblHoraPartida.Text + Convert.ToString(value: vuelo.HoraSalida);
            lblHoraLlegada.Text = lblHoraLlegada.Text + Convert.ToString(value: vuelo.HoraLlegada);
            lblPreico.Text = lblPreico.Text + Convert.ToString(value: vuelo.Precio);

            vueloSeleccionado = vuelo;
            
        }

        /// <summary>
        /// Lista de objetos Reserva
        /// </summary>
        /// <returns></returns>
        public List<Reserva> ObtenerReservas()
        {
            List<Reserva> listaReservas = new List<Reserva>();

            string consulta = "SELECT idReserva, nombre, fechaReserva, asientos, cacelada, idVuelo, idPago FROM reserva";

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        int tinyInt = reader.GetInt32("cacelada");
                        // Crea un nuevo objeto reserva con los datos de cada fila
                        Reserva reserva = new Reserva
                        {
                            IDReserva = reader.GetInt32("idReserva"),
                            Nombre = reader.GetString("nombre"),
                            FechaReserva = reader.GetDateTime("fechaReserva"),
                            Asientos = reader.GetInt32("asientos"),
                            Cancelada = tinyInt==1?true:false,
                            
                            IdVuelo = reader.GetInt32("idVuelo"),
                            IdPago = reader.GetInt32("idPago")
                        };

                        listaReservas.Add(reserva);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener las reservas: " + ex.Message);
                }
                finally
                {
                    ConexionBD.CerrarConexion(conexion);
                }
            }

            return listaReservas;
        }//fin del metodo

        /// <summary>
        /// lista de objetos Pago
        /// </summary>
        /// <returns></returns>
        public List<Pago> ObtenerPagos()
        {
            List<Pago> listaPagos = new List<Pago>();

            string consulta = "SELECT idPago, metodoPago, subtotal, recargo, total FROM pago";

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        // Crea un nuevo objeto pago con los datos de cada fila
                        Pago pago = new Pago
                        {
                            IDPago = reader.GetInt32("idPago"),
                            MetodoPago = reader.GetString("metodoPago"),
                            Subtotal = reader.GetDouble("subtotal"),
                            Recargo = reader.GetDouble("recargo"),
                            Total = reader.GetDouble("total")
                            
                        };

                        listaPagos.Add(pago);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener los pagos: " + ex.Message);
                }
                finally
                {
                    ConexionBD.CerrarConexion(conexion);
                }
            }

            return listaPagos;
        }//fin del metodo


        /// <summary>
        /// Evento se desencadena cuando se preciona el boton confirmar reserva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservar_Click(object sender, EventArgs e)
        {
            List<Reserva> listaReservas = ObtenerReservas();
            List<Pago> listaPagos = ObtenerPagos();


            //Valida si el texbox esta vacio
            if (string.IsNullOrWhiteSpace(txtAsientos.Text) || (string.IsNullOrWhiteSpace(txtNombre.Text)))
            {
                MessageBox.Show("no puede dejar campos vacios");
                return;
            }
            //Verifica si el vuelo esta lleno
            if (vueloSeleccionado.Pasajeros >= 50)
            {
                MessageBox.Show("lo sentimos el vuelo esta lleno");
                return;
            }

            
            
           
                //suma la cantidad de asientos reservada a la de los pasajeros en el avion
                vueloSeleccionado.Pasajeros = vueloSeleccionado.Pasajeros + Convert.ToInt32(txtAsientos.Text);


                //creamos un nuevo objeto reserva para guardar los datos dela reserva que se esta haciendo
                Reserva reservaActual = new Reserva();
                reservaActual.IDReserva = listaReservas.Count + 1;
                reservaActual.Nombre = txtNombre.Text;
                reservaActual.FechaReserva = DateTime.Now;
                string fechaReservaStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
                reservaActual.Asientos = Convert.ToInt32(txtAsientos.Text);
                reservaActual.Cancelada = false;
                reservaActual.IdVuelo = vueloSeleccionado.IDVuelo;
                reservaActual.IdPago = listaPagos.Count + 1;

            Form3 formPago = new Form3(reservaActual, vueloSeleccionado);
            formPago.ShowDialog(); // Mostrar como cuadro de diálogo modal

            //Actualizamos la base de datos con las reservas 
            int idVuelo = vueloSeleccionado.IDVuelo;
            int nuevosPasajeros = vueloSeleccionado.Pasajeros;
            string consulta = $"UPDATE vuelos SET pasajeros = {nuevosPasajeros} WHERE idVuelo = {idVuelo}";
            
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

            

        }//fin del evento

        /// <summary>
        /// Evento se desencadena cuando el ususarion intenta introducir caracteres no deseados
        /// bloquea la entrada de texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAsientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

        /// <summary>
        /// event se desencadena cuando un n usuario introduce caracteres no deseados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
