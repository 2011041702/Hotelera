using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotelera.Dominio
{
    public abstract class ServicioDecorador:Servicios
    {
        
        
        public override abstract decimal calcularCosto();


        public override abstract string descripcion();
        

    }
}