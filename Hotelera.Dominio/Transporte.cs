using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotelera.Dominio
{
    public class Transporte:ServicioDecorador
    {
        private Servicios tmpServicio;
        public Transporte(Servicios Servicio)
        {
            this.tmpServicio = Servicio;
        }
        public override decimal calcularCosto()
        {
            return tmpServicio.calcularCosto() + 10.00m;
        }

        public override string descripcion()
        {
            return tmpServicio.descripcion() + "S. de Transaporte d/hacia al aeropuerto";
        }
    }
}