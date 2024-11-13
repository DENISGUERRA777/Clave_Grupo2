using Clave_Grupo2.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clave_Grupo2
{
    /// <summary>
    /// Clase frincipal del proyecto
    /// </summary>
    public partial class Form1 : Form
    {
        private List<Reserva> listaReservas;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metodo qye se coneccta a la db y crea una lista de objetos Vuelo
        /// </summary>
        /// <returns></returns>
        public List<Vuelo> ObtenerVuelos()
        {
            List<Vuelo> listaVuelos = new List<Vuelo>();

            string consulta = "SELECT idVuelo, origen, destino, horaSalida, horaLlegada, pasajeros, precio FROM vuelos";

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        // Crea un nuevo objeto Vuelo con los datos de cada fila
                        Vuelo vuelo = new Vuelo
                        {
                            IDVuelo = reader.GetInt32("idVuelo"),
                            Origen = reader.GetString("origen"),
                            Destino = reader.GetString("destino"),
                            HoraSalida = reader.GetDateTime("horaSalida"),
                            HoraLlegada = reader.GetDateTime("horaLlegada"),
                            Pasajeros = reader.GetInt32("pasajeros"),
                            Precio = reader.GetDouble("precio")
                        };

                        listaVuelos.Add(vuelo);
                    }

                    reader.Close();
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

            return listaVuelos;
        }//fin del metodo

        



        /// <summary>
        /// Evento se desencadena cuando el usuario intenta introducir caracteres no deseados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si el usuario ntenta ingresar simbolos o numeros se bloquea la escritura
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Evento se desencadena cuando el ususario intenta introducir caracteres no deseados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si el usuario ntenta ingresar simbolos o numeros se bloquea la escritura
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento se desencadena cuando se quieren introducir datos al textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxHora_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = true;
        }

        /// <summary>
        /// Evento se desencadena cuando se quieren introducir datos al textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        /// <summary>
        /// Evento se desencadena cuando el usuarion hace click en el boton buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores seleccionados en ambos ComboBox
            string origenSeleccionado = cboxOrigen.Text;
            string destinoSeleccionado = cboxDestino.Text;
            DateTime fechaSeleccionada = Convert.ToDateTime(dtpickFecha.Text);


            // Filtrar la lista original de vuelos (listaVuelos) con los criterios seleccionados
            List<Vuelo> vuelosFiltrados = ObtenerVuelos()
                .Where(v => v.Origen == origenSeleccionado &&  v.Destino == destinoSeleccionado && v.HoraSalida == fechaSeleccionada)
                .ToList();

            // Mostrar los resultados filtrados en un DataGridView o en otro control
            dgviwVuelos.DataSource = vuelosFiltrados;

        }//fin del evento



        

        /// <summary>
        /// metodo para autocompletar cboxOrigen con datos de la db
        /// </summary>
        private void LlenarCBoxOrigen()
        {
            // Obtiene la lista de vuelos
            List<Vuelo> listaVuelos = ObtenerVuelos();

            // Configura el ComboBox
            cboxOrigen.DataSource = listaVuelos;
            cboxOrigen.DisplayMember = "Origen";  // Propiedad que deseas mostrar
            cboxOrigen.ValueMember = "IDVuelo";    // Propiedad para identificar cada elemento

            // configura autocompletado
            cboxOrigen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxOrigen.AutoCompleteSource = AutoCompleteSource.ListItems;
            // Llenar el segundo ComboBox solo con las horas de salida
            LlenarComboBoxHorasSalida(listaVuelos);
        }

        /// <summary>
        /// metodo para autocompletar cboxDestino con datods de la db
        /// </summary>
        private void LlenarCBoxDestino()
        {
            // Obtiene la lista de vuelos
            List<Vuelo> listaVuelos = ObtenerVuelos();

            // Configura el ComboBox
            cboxDestino.DataSource = listaVuelos;
            cboxDestino.DisplayMember = "Destino";  // Propiedad que deseas mostrar
            cboxDestino.ValueMember = "IDVuelo";    // Propiedad para identificar cada elemento

            // configura autocompletado
            cboxDestino.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxDestino.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        /// <summary>
        /// Evento se desencadena cuando se carga el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load_1(object sender, EventArgs e)
        {
            LlenarCBoxOrigen();
            LlenarCBoxDestino();
            cboxDestino.SelectedIndexChanged += new EventHandler(cboxDestino_SelectedIndexChanged);

        }

        /// <summary>
        /// Evento se desencadena cuando se selecciona una opcion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si hay un vuelo seleccionado
            Vuelo vueloSeleccionado = cboxDestino.SelectedItem as Vuelo;

            if (vueloSeleccionado != null)
            {
                // Actualiza el DateTimePicker con la hora de salida del vuelo seleccionado
                dtpickFecha.Value = vueloSeleccionado.HoraSalida;
            }
        }

        /// <summary>
        /// metodo para autocompletar cboxDestino con datods de la db
        /// </summary>
        private void LlenarComboBoxHorasSalida(List<Vuelo> vuelos)
        {
            List<string> horasSalida = new List<string>();

            foreach (var vuelo in vuelos)
            {
                // Convertir la hora de salida a formato HH:mm
                string hora = vuelo.HoraSalida.ToString("HH:mm");
                horasSalida.Add(hora);
            }

            // Asignar la lista de horas de salida al ComboBox
            cboxHora.DataSource = horasSalida;

            // Configurar autocompletado para el ComboBox
            cboxHora.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxHora.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        /// <summary>
        /// Evento se desencadena cuando el usuario clickea en una celda del data gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgviwVuelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) //se asegura de que no sea una cabecera la que esté seleccionada
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgviwVuelos.Rows[e.RowIndex];

                // Extraer los valores de la fila seleccionada
                int idVuelo = Convert.ToInt32(filaSeleccionada.Cells["IDVuelo"].Value);
                string origen = filaSeleccionada.Cells["Origen"].Value.ToString();
                string destino = filaSeleccionada.Cells["Destino"].Value.ToString();
                DateTime horaSalida = Convert.ToDateTime(filaSeleccionada.Cells["HoraSalida"].Value);
                DateTime horaLlegada = Convert.ToDateTime(filaSeleccionada.Cells["HoraLlegada"].Value);
                int pasajeros = Convert.ToInt32(filaSeleccionada.Cells["Pasajeros"].Value);
                double precio = Convert.ToDouble(filaSeleccionada.Cells["Precio"].Value);
                // Crear el objeto Vuelo con los datos extraídos
                
                Vuelo vuelo = new Vuelo(idVuelo, origen, destino, horaSalida, horaLlegada, pasajeros, precio);
                // Crear y mostrar el formulario de vuelo, pasando la reserva como parámetro
                Form2 formReserva = new Form2(vuelo);
                formReserva.ShowDialog(); // Mostrar como cuadro de diálogo modal
            }
        }
        /// <summary>
        /// Evento se desencadena cuando se presiona el boton limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpia el datagrid
            dgviwVuelos.Rows.Clear();
        }

        /// <summary>
        /// evento se desencadena cuando se presiona el boton salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cierra la aplicacion
            Application.Exit();
        }

        /// <summary>
        /// Evento se desencadena cuando se introducen caracteres no deseados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// evento se desencadena cuando se presiona el boton cancelar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            
            
            
            int id = Convert.ToInt32(txtBusqueda.Text);
            string consulta1 = $"UPDATE reserva SET cacelada = 1 WHERE idReserva = {id}";

            using (MySqlConnection conexion1 = ConexionBD.ObtenerConexion())
            {
                try
                {


                    MySqlCommand comando = new MySqlCommand(consulta1, conexion1);
                    int filasAfectadas = comando.ExecuteNonQuery();
                    MessageBox.Show($"Se encontro su reserva y fue cancelada con exito sele reenvolsara a su cuenta bancaria {txtBusqueda.Text}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener los vuelos: " + ex.Message);
                }
                finally
                {
                    ConexionBD.CerrarConexion(conexion1);
                }
            }
           
        }
    }
}
