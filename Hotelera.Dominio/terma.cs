using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class terma
    {
             ///    <sumary>
    ///     Parametros de servicio de terma
    ///    </sumary>
        public int precio { get; private set; }
        public string descripcion { get; private set; }
 ///    <sumary>
    ///     Asignacion de costo extra de servicio de Terma
    ///    </sumary>
        public void costo()
        {
            precio = 10;
            descripcion =" mas terma";
        }
    }
}
