using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Hotelera.Infraestructura
{
     /// <summary>
        ///  Para hacer una conexion con nuestra BD a traves del contexto
        /// </summary>
    public class InicializadorBD : CreateDatabaseIfNotExists<HoteleraContexto>
    {
        protected override void Seed(HoteleraContexto context)
        {
            base.Seed(context);
        }
    }
}
