using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    class tvcable
    {
        public int precio { get; private set; }
        public string descripcion { get; private set; }

        public void costo()
        {
            precio = 5;
            descripcion = " mas tvclabe ";
        }
    }
}
