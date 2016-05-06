using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Hotelera.Infraestructura
{
        /// <summary>
        /// Esta clase es vital para la correlacion de nuestra DB con el Contexo para realizar consultas o la interaccion misma
        /// </summary>
    public class ContextoBase<T> : DbContext where T : DbContext
    {
        public ContextoBase(string as_conexion)
            : base(as_conexion)
        {
            Database.SetInitializer<T>(null);
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            //Configuration.ProxyCreationEnabled = false;
        }
    }
}
