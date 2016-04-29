using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Usuario
    {
        public int ID_usu { get; private set; }
        public virtual Empleado id_Personal { get; private set; }
        public string Nombre_Usuario { get; private set; }
        public string Contraseña_Usuario { get; private set; }
        public virtual Estado_Usuario ID_Estado { get; private set; }
        public virtual Acceso_Usuario ID_AccesoUsuario { get; private set; }
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
        public void Actualizar(int id_us,Empleado id_pers, string nomb_usu, string contra_usu, Estado_Usuario id_estad)
        {
            ID_usu = id_us;
            id_Personal = id_pers;
            Nombre_Usuario = nomb_usu;
            Contraseña_Usuario = contra_usu;
            ID_Estado = id_estad;
        }
        public void Bloquear()
        {
       
        }
    }
}
