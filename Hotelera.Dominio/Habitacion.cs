using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Habitacion
    {
        public int ID_Habitacion { get; private set; }
        public int Numero_Habitacion { get; private set; }
        public int Numero_Piso { get; private set; }
        public string Descripcion_Habitacion { get; private set; }
        public string Tipo_Habitacion { get; private set; }
        public string Estado_Habitacion { get; private set; }
        /// <summary>
        /// Metodo para Registrar una Habitacion
        /// </summary>
        /// <param name="num_hab"></param>
        /// <param name="num_piso"></param>
        /// <param name="descrip_habit"></param>
        /// <param name="tip_hab"></param>
        /// <param name="estado_habit"></param>
        /// <returns></returns>
        public static Habitacion Registrar(int num_hab, int num_piso, string descrip_habit, string tip_hab, string estado_habit)
        {
            return new Habitacion()
            {
                Numero_Habitacion = num_hab,
                Numero_Piso = num_piso,
                Descripcion_Habitacion = descrip_habit,
                Tipo_Habitacion = tip_hab,
                Estado_Habitacion = estado_habit
            };
        }
        /// <summary>
        /// Actualizamos la Informacion de una habitacion
        /// </summary>
        /// <param name="id_habit"></param>
        /// <param name="num_hab"></param>
        /// <param name="num_piso"></param>
        /// <param name="descrip_habit"></param>
        /// <param name="tip_hab"></param>
        /// <param name="estado_habit"></param>
        public void Actualizar(int id_habit, int num_hab, int num_piso, string descrip_habit, string tip_hab, string estado_habit)
        {
            ID_Habitacion = id_habit;
            Numero_Habitacion = num_hab;
            Numero_Piso = num_piso;
            Descripcion_Habitacion = descrip_habit;
            Tipo_Habitacion = tip_hab;
            Estado_Habitacion = estado_habit;
        }
        /// <summary>
        /// Cambiamos el estado de una habittacion
        /// </summary>
        public void CambiarEstado()
        {
            Estado_Habitacion = "FUERA DE SERVICIO";
        }
        public void verDisponibilidad() { }
    }
}
