using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Inventario
    {
        
        /// <summary>
        ///  Parametros de la clase Inventario
        /// </summary>
        public int ID_Inventario { get; private set; }
        public virtual Proveedor ID_Pro { get; private set; }
        public string Estado_Inventario { get; private set; }
        
        /// <summary>
        ///  Metodo para Ingresar un Inventario
        /// </summary>
        /// <param name="id_prov">Id del Proveedor</param>
        /// <param name="estado_inv">Estado del Inventario</param>
        public static Inventario Registrar(Proveedor id_prov,string estado_inv)
        {
            return new Inventario()
            {
                ID_Pro = id_prov,
                Estado_Inventario = estado_inv
            };
        }
        
        
        /// <summary>
        ///  Metodo para Actualizar un Inventario
        /// </summary>
        /// <param name="id_inven">Id del Inventario</param>
        /// <param name="id_prov">Id del Proveedor</param>
        /// <param name="estado_inv">Estado del Inventario</param>
        public void Actualizar(int id_inven,Proveedor id_prov, string estado_inv)
        {
            ID_Inventario = id_inven;
            ID_Pro = id_prov;
            Estado_Inventario = estado_inv;
        }
        
        
        /// <summary>
        ///  Metodo para Anular un Inventario
        /// </summary>
        public void Anular()
        {
            Estado_Inventario = "ELIMINADO";
        }
    }
}
