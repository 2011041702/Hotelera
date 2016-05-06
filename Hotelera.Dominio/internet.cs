using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class internet
    {
         ///    <sumary>
    ///     Parametros de servicio de internet
    ///    </sumary>
        public int precio { get; private set; }
        public string descripcion { get; private set; }

 ///    <sumary>
    ///     Asignacion de costo extra de servicio de internet
    ///    </sumary>
        public void costo()
        {
            precio = 20;
            descripcion =" mas internet ";
        }
    }

    
}
