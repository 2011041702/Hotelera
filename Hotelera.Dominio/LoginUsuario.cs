using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotelera.Dominio
{
    public class LoginUsuario
    {
         /// <summary>
        ///  Parametros de la clase LoginUsuario
        /// </summary>
        public int ID_Login { get; private set; }
        public virtual Usuario ID_Usuario { get; private set; }
        public DateTime Fecha_Ingresada { get; private set; }
        public string IP_Login { get; private set; }

    }
}
