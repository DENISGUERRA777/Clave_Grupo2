using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave_Grupo2.Clases
{
    /// <summary>
    /// Clase para guardar informacion sobre los las reservaciones de vuelos
    /// </summary>
    public class Reserva
    {
        //Atrributos de clase
        private int idReserva;
        private string nombre;
        private DateTime fechaReserva;
       
        private int asientos;
        private bool cancelada;
        private int idVuelo;
        private int idPago;

        //Metodos Accesores y Mutadores
        public int IDReserva { get => idReserva; set => idReserva = value; }
        public string Nombre
        {
            get => nombre; set => nombre = value;
        }
        public DateTime FechaReserva
        {
            get => fechaReserva; set => fechaReserva = value;
        }
        
        public int Asientos { get => asientos; set => asientos = value; }
        public bool Cancelada { get => cancelada; set => cancelada = value; }
        public int IdVuelo { get => idVuelo; set => idVuelo = value; }
        public int IdPago { get => idPago; set => idPago = value; }

        //Constructor de clase
        public Reserva(int idReserva, string nombre, DateTime fechaReserva, double precio, int asientos, bool cancelada, int idVuelo, int idPago)
        {
            IDReserva = idReserva;
            Nombre = nombre;
            FechaReserva = fechaReserva;
            
            Asientos = asientos;
            Cancelada = cancelada;
            IdVuelo = idVuelo;
            IdPago = idPago;
        }
        //Constructor por defecto
        public Reserva()
        {
        }
    }
}
