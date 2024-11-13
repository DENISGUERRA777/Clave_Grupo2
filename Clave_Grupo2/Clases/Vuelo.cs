using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clave_Grupo2.Clases
{
    /// <summary>
    /// Clase para guardar informacion sobre los vuelos disponibles
    /// </summary>
    public class Vuelo
    {
        //Atrributos de clase
        private int idVuelo;
        private string origen;
        private string destino;
        private DateTime horaSalida;
        private DateTime horaLlegada;
        private int pasajeros;
        private double precio;

        //Metodos Accesores y Mutadores
        public int IDVuelo { get => idVuelo; set => idVuelo = value; }
        public string Origen
        {
            get => origen; set => origen = value;
        }
        public string Destino
        {
            get => destino; set => destino= value;
        }
        public DateTime HoraSalida { get => horaSalida; set => horaSalida = value; }
        public DateTime HoraLlegada { get => horaLlegada; set => horaLlegada = value; }
        public int Pasajeros { get => pasajeros; set => pasajeros = value; }
        public double Precio { get => precio; set => precio = value; }

        //Constructor de clase
        public Vuelo(int idVuelo, string origen, string destino, DateTime horaSalida, DateTime horaLlegada, int pasajeros, double precio)
        {
            IDVuelo = idVuelo;
            Origen = origen;
            Destino = destino;
            HoraSalida = horaSalida;
            HoraLlegada = horaLlegada;
            Pasajeros = pasajeros;
            Precio = precio;
        }
        //Constructor por defecto
        public Vuelo()
        {
        }
    }
}
