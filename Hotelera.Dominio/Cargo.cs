using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//asignamos las librerias que vamos a usar
namespace Hotelera.Dominio
{

    public class Cargo
    {
        //creamos las variables de la clase cargo
        //encapsulamos las variables con el private
        public int ID_Cargo { get; private set; }
        public string Nombre_Cargo { get; private set; }
        public string Descripcion_Cargo { get; private set; }
        public decimal Sueldo_Cargo { get; private set; }
        public string Estado_Cargo { get; private set; }

        //Constructor
        public Cargo(int id_cargo, string nomb_cargo, string desc_cargo, decimal sueldo_cargo, string estado_cargo)
        {
            this.ID_Cargo = id_cargo;
            this.Nombre_Cargo = nomb_cargo;
            this.Descripcion_Cargo = desc_cargo;
            this.Sueldo_Cargo = sueldo_cargo;
            this.Estado_Cargo = estado_cargo;
        }

        public Cargo()
        {
        }

        public static Cargo Registrar (int id_cargo,string nomb_carg, string descrip_carg, decimal sueld,string estado_carg)
        {
            return new Cargo()
            {
                ID_Cargo=id_cargo,
                Nombre_Cargo = nomb_carg,
                Descripcion_Cargo = descrip_carg,
                Sueldo_Cargo = sueld,
                Estado_Cargo = estado_carg
            };
        }
        public void Actualizar(int id_carg,string nomb_carg, string descrip_carg, decimal sueld,string estado_carg)
        {
            {
            ID_Cargo = id_carg;
            Nombre_Cargo = nomb_carg;
            Descripcion_Cargo = descrip_carg;
            Sueldo_Cargo = sueld;
            Estado_Cargo = estado_carg;
            }
        }
        public void Anular()
        {
            Estado_Cargo = "ELIMINADO";
        }
    }
}
