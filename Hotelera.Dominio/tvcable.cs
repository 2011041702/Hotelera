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

    class Tvcable
    {
        public int precio { get; private set; }
        public string descripcion { get; private set; }

    ///    <sumary>
    ///     Asignacion de costo extra de servicio
    ///    </sumary>
    
        public void costo()
        {
            precio = 5;
            descripcion = " mas tvclabe ";
        }
    }
}
