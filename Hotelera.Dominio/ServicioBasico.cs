using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotelera.Dominio
{
    public class ServicioBasico : Servicios
    {
        public override decimal calcularCosto()
        {
            return 20.00m;
        }

        public override string descripcion()
        {
            return "Servicio Basico presenta Desayuno, Internet Wifi";
        }
    }
}