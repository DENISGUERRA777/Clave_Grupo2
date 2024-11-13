using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave_Grupo2.Clases
{
    /// <summary>
    /// Clase para guardar informacion sobre los pagos 
    /// </summary>
    public class Pago
    {
        //Atrributos de clase
        private int idPago;
        private string metodoPago;
        private double subtotal;
        private double recargo;
        private double total;

        //Metodos Accesores y Mutadores
        public int IDPago { get => idPago; set => idPago = value; }
        public string MetodoPago
        {
            get => metodoPago; set => metodoPago = value;
        }
        public double Subtotal
        {
            get => subtotal; set => subtotal = value;
        }
        public double Recargo { get => recargo; set => recargo = value; }
        public double Total { get => total; set => total = value; }

        //Constructor de clase
        public Pago(int idPago, string metodoPago, double subtotal, double recargo, double total)
        {
            IDPago = idPago;
            MetodoPago = metodoPago;
            Subtotal = subtotal;
            Recargo = recargo;
            Total = total;
        }
        //Constructor por defecto
        public Pago()
        {
        }
    }
}
