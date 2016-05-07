using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    /// <summary>
        ///  Parametros de tvcable
        /// </summary>

    public class Tvcable : ServicioDecorador
    {
        private Servicios tmpServicio;
        public Tvcable(Servicios Servicio)
        {
            this.tmpServicio = Servicio;
        }
        public override decimal calcularCosto()
        {
            return tmpServicio.calcularCosto() + 10.00m;
        }

        public override string descripcion()
        {
            return tmpServicio.descripcion() + "Television Cable";
        }
    }
}
