using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Reserva
    {
        /// <summary>
        ///  Parametros de Reserva
        /// </summary>
        public int ID_Reserva { get; private set; }
        public virtual Habitacion ID_Habitacion { get; private set; }
        public virtual Cliente ID_Cliente { get; private set; }
        public virtual Usuario ID_Usuario { get; private set; }
        public virtual TipoReserva ID_TipoReserva { get; private set; }
        public virtual MedioReserva ID_MedioReserva { get; private set; }
        public string Estado_Reserva { get; private set; }
        public DateTime Fecha_Reserva { get; private set; }
        public DateTime Fecha_IngresoReserva { get; private set; }
        public DateTime Fecha_SalidaReserva { get; private set; }
        public virtual Agregados ID_Agregados { get; private set; }
        
        /// <summary>
        ///  Metodo para Aperturar una Reserva
        /// </summary>
        /// <param name="id_hab">Id de habitacion</param>
        /// <param name="id_client">Id del Cliente</param>
        /// <param name="id_usu">Id de usuario</param>
        /// <param name="id_tipreserv">id tipo de servicio</param>
        /// <param name="id_medioreserv">id medio por cual se hace el servicio</param>
        /// <param name="estado_reserv">Estado de la Reserva</param>
        /// <param name="fecha_reserv">fecha de reserva</param>
        /// <param name="fecha_ingreso">fecha de ingreso</param>
        /// <param name="fecha_salida">fecha de salida/param>
        /// <param name="id_agregad">Id Agregados</param>
        
        public virtual Reserva Aperturar(Habitacion id_hab, Cliente id_client,Usuario id_usu,TipoReserva id_tipreserv, MedioReserva id_medioreserv,string estado_reserv,DateTime fecha_reserv, DateTime fecha_ingreso, DateTime fecha_salida, Agregados id_agregad)
        {
            return new Reserva()
            {
                ID_Habitacion = id_hab,
                ID_Cliente = id_client,
                ID_Usuario = id_usu,
                ID_TipoReserva = id_tipreserv,
                ID_MedioReserva = id_medioreserv,
                Estado_Reserva = estado_reserv,
                Fecha_Reserva = fecha_reserv,
                Fecha_IngresoReserva = fecha_ingreso,
                Fecha_SalidaReserva = fecha_salida,
                ID_Agregados = id_agregad
            };
        }
        
        /// <summary>
        ///  Metodo para actualizar una Reserva
        /// </summary>
        /// <param name="id_hab">Id de habitacion</param>
        /// <param name="id_client">Id del Cliente</param>
        /// <param name="id_usu">Id de usuario</param>
        /// <param name="id_tipreserv">id tipo de servicio</param>
        /// <param name="id_medioreserv">id medio por cual se hace el servicio</param>
        /// <param name="estado_reserv">Estado de la Reserva</param>
        /// <param name="fecha_reserv">fecha de reserva</param>
        /// <param name="fecha_ingreso">fecha de ingreso</param>
        /// <param name="fecha_salida">fecha de salida/param>
        /// <param name="id_agregad">Id Agregados</param>
        public void Actualizar(Habitacion id_hab, Cliente id_client, Usuario id_usu, TipoReserva id_tipreserv, MedioReserva id_medioreserv, string estado_reserv, DateTime fecha_reserv, DateTime fecha_ingreso, DateTime fecha_salida, Agregados id_agregad)
        {
            ID_Habitacion = id_hab;
            ID_Cliente = id_client;
            ID_Usuario = id_usu;
            ID_TipoReserva = id_tipreserv;
            ID_MedioReserva = id_medioreserv;
            Estado_Reserva = estado_reserv;
            Fecha_Reserva = fecha_reserv;
            Fecha_IngresoReserva = fecha_ingreso;
            Fecha_SalidaReserva = fecha_salida;
            ID_Agregados = id_agregad;
        }
        
        /// <summary>
        ///  Metodo para Anular una Reserva
        /// </summary>
        public void Anular()
        {
            Estado_Reserva = "ELIMINADO";            
        }
    }
}
