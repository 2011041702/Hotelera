using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria

namespace Hotelera.Dominio
    //ej


{
    
    public class Agregados
    {
        public int ID_Agregados { get; private set; }
        public virtual Servicios ID_Servicios { get; private set; }
        public string Estado_Servicios { get; private set; }

        /// <summary>
        /// Agregamos Los servicios extras
        /// </summary>
        /// <param name="id_serv"></param>
        /// <param name="estado_serv"></param>
        /// <returns></returns>
        public static Agregados Agregar(Servicios id_serv,string estado_serv)
        {
            return new Agregados()
            {
                ID_Servicios = id_serv,
                Estado_Servicios = estado_serv
            };
        }
        /// <summary>
        /// Actualizamos la informacion
        /// </summary>
        /// <param name="id_agreg"></param>
        /// <param name="id_serv"></param>
        /// <param name="estado_serv"></param>
        public void Actualizar(int id_agreg,Servicios id_serv, string estado_serv)
        {
            ID_Agregados = id_agreg;
            ID_Servicios = id_serv;
            Estado_Servicios = estado_serv;
        }
        /// <summary>
        /// Es para anular algun agregado
        /// </summary>
        public void Anular()
        {
            Estado_Servicios = "ELIMINADO";
        }
    }
}
