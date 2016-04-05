using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class MedioReserva
    {
        public int ID_MedioReserva { get; private set; }
        public string Nombre_Reserva { get; private set; }
        public string Estado_MedioReserva { get; private set; }

        /// <summary>
        /// En este metodo podemos Registrar el Medio de Reserva
        /// </summary>
        /// <param name="nomb_reserv"></param>
        /// <param name="estado_medioreserv"></param>
        /// <returns></returns>
        public static MedioReserva Registrar(string nomb_reserv, string estado_medioreserv)
        {
            return new MedioReserva()
            {
                Nombre_Reserva = nomb_reserv,
                Estado_MedioReserva = estado_medioreserv
            };
        }

        /// <summary>
        /// Actualizar los Medios de Reserva
        /// </summary>
        /// <param name="id_medio"></param>
        /// <param name="nomb_reserv"></param>
        /// <param name="estado_medioreserv"></param>
        public void Actualizar(int id_medio,string nomb_reserv, string estado_medioreserv)
        {
           ID_MedioReserva = id_medio;
           Nombre_Reserva = nomb_reserv;
           Estado_MedioReserva = estado_medioreserv;
        }
        /// <summary>
        /// Cambia el metodo de El metodo de Pago
        /// </summary>
        public void Anular()
        {
            Estado_MedioReserva = "ELIMINADO";
        }
    }
}
