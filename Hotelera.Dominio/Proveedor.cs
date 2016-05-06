using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Proveedor : Persona
    {
        /// <summary>
        ///  Parametros de Proveedor
        /// </summary>
        public int ID_Proveedor { get; private set; }
        public string Estado_Proveedor { get; private set; }

        /// <summary>
        ///  Metodo insertar un Proveedor , los demas parametros los jala de la clase Cliente
        /// </summary>
        /// <param name="id_pro">Id de Provedor</param>
        /// <param name="estado_pro">Estado del Provedor</param>
        public Proveedor(int id_pro, string estado_pro, string nombre_cli, string apel_cli, string gen_cli, string tipoDoc_cli,
                                                            string nrDoc_cli, string tel_cli, string email_cli, string dir_cli) 
                                                            :base( nombre_cli, apel_cli, gen_cli, tipoDoc_cli,
                                                             nrDoc_cli,  tel_cli, email_cli, dir_cli)
        {
            this.ID_Proveedor = id_pro;
            this.Estado_Proveedor = estado_pro;
        }
        
        /// <summary>
        ///  Metodo para actualizar un Proveedor
        /// </summary>
        /// <param name="id_pro">Id de Provedor</param>
        /// <param name="estado_pro">Estado del Provedor</param>
        public void Actualizar(int id_prov, string estado_provee)
        {
            ID_Proveedor = id_prov;
            
            Estado_Proveedor = estado_provee;
        }
        
        /// <summary>
        ///  Metodo para Anular un Proveedor
        /// </summary>
        public void Anular()
        {
            Estado_Proveedor = "INACTIVO";
        }
    }
}
