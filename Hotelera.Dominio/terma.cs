using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class terma
    {
        public int precio { get; private set; }
        public string descripcion { get; private set; }

        public void costo()
        {
            precio = 10;
            descripcion =" mas terma";
        }
    }
}
