using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class TipoReserva
    {
        /// <summary>
        ///  Parametros de Tipo de Reserva
        /// </summary>
        public int ID_TipoReserva { get; private set; }
        public string Nombre_TipoReserva { get; private set; }
        
        /// <summary>
        ///  Metodo para registrar un Tipo de Reserva
        /// </summary>
        /// <param name="nomb_tiporeserva">Nombre del tipo de reserva</param>
        public static TipoReserva Registrar(string nomb_tiporeserva)
        {
            return new TipoReserva()
            {
                Nombre_TipoReserva = nomb_tiporeserva
            };
        }
        
        /// <summary>
        ///  Metodo para actualizar un Tipo de Reserva
        /// </summary>
        /// <param name="id_tiporeserva">Id del tipo de reserva</param>
        /// <param name="nomb_tiporeserva">Nombre del tipo de reserva</param>
        public void Actualizar(int id_tiporeserva,string nomb_tiporeserva)
        {
            ID_TipoReserva = id_tiporeserva;
            Nombre_TipoReserva = nomb_tiporeserva;            
        }
        
        /// <summary>
        ///  Metodo para Anular un Tipo de Reserva
        /// </summary>
        public void Anular()
        {
            
        }
    }
}
