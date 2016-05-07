using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotelera.Dominio
{
    public class ServicioPremium:Servicios
    {
        public override decimal calcularCosto()
        {
            return 30.00m;
        }

        public override string descripcion()
        {
            return "Servicio PremiumServicio Basico presenta Desayuno, Internet Wifi , estacionamiento";
        }
    }
}