using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Estado_Usuario
    {
        public int ID_Estado { get; private set; }
        public string Nombre_Estado { get; private set; }        
        /// <summary>
        /// Aca podemos registrar los diferentes estados que encontramos en la BD
        /// </summary>
        /// <param name="nomb_estad"></param>
        /// <returns></returns>
        public static Estado_Usuario Registrar(string nomb_estad)
        {
            return new Estado_Usuario()
            {
                Nombre_Estado = nomb_estad
            };
        }
        /// <summary>
        /// Actualizamos la los estados de la BD 
        /// </summary>
        /// <param name="id_est"></param>
        /// <param name="nomb_estad"></param>
        public void Actualizar(int id_est, string nomb_estad)
        {
            ID_Estado = id_est;
            Nombre_Estado = nomb_estad;
        }        
    }
}
