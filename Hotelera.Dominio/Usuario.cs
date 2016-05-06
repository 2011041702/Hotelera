using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Usuario
    {
        /// <summary>
        /// Parametros de los Usuarios
        /// </summary>
        public int ID_usu { get; private set; }
        public virtual Empleado id_Personal { get; private set; }
        public string Nombre_Usuario { get; private set; }
        public string Contraseña_Usuario { get; private set; }
        public virtual Estado_Usuario ID_Estado { get; private set; }
        public virtual Acceso_Usuario ID_AccesoUsuario { get; private set; }
        
         /// <summary>
        ///  Para Registrar la informacioon de un Usuario
        /// </summary>
        /// <param name="id_pers">Id del Personal</param>
        /// <param name="nomb_usu">Nombre del usuario</param>
        /// <param name="contra_usu">Contraseña de Usuario</param>
        /// <param name="id_estad">Id de estado para el Usuario</param>
        public static Usuario Registrar(Empleado id_pers, string nomb_usu, string contra_usu, Estado_Usuario id_estad)
        {
            return new Usuario()
            {
                id_Personal = id_pers,
                Nombre_Usuario = nomb_usu,
                Contraseña_Usuario = contra_usu,
                ID_Estado = id_estad
            };
        }
        
        /// <summary>
        ///  Para Actualizar la informacioon de un Usuario
        /// </summary>
        /// <param name="id_us">Id del Usuario</param>
        /// <param name="id_pers">Id del Personal</param>
        /// <param name="nomb_usu">Nombre del usuario</param>
        /// <param name="contra_usu">Contraseña de Usuario</param>
        /// <param name="id_estad">Id de estado para el Usuario</param>
        public void Actualizar(int id_us,Empleado id_pers, string nomb_usu, string contra_usu, Estado_Usuario id_estad)
        {
            ID_usu = id_us;
            id_Personal = id_pers;
            Nombre_Usuario = nomb_usu;
            Contraseña_Usuario = contra_usu;
            ID_Estado = id_estad;
        }
        
        /// <summary>
        ///  Metodo para bloquear un Usuario
        /// </summary>
        public void Bloquear()
        {
       
        }
    }
}
