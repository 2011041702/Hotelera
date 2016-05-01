using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotelera.Dominio
{
    public class Pagos
    {
        public virtual Reserva ID_Reserva { get; private set; }
        public int ID_Pagos { get; private set; }
        public virtual TipoPago ID_TipoPago { get; private set; }
        public virtual Comprobante_Pago ID_Comprobante { get; private set; }
        public DateTime Fecha_Emision { get; private set; }
        public DateTime Fecha_Pago { get; private set; }

        public void grabarVenta()
        {
            throw new System.NotImplementedException();
        }
    }
}