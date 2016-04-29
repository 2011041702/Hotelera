using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotelera.Dominio;
namespace Hotelera.Dominio
{
    public class Empleado : Persona
    {
        public int ID_Personal { get; private set; }
        public virtual Cargo ID_Cargo { get; private set; }
        public string Estado_Empleado { get; private set; }
   
        public Empleado(Cargo id_cargo,int id_per, string estado_per, string nombre_cli, string apel_cli, string gen_cli, string tipoDoc_cli,
                                                            string nrDoc_cli, string tel_cli, string email_cli, string dir_cli) 
                                                            :base( nombre_cli, apel_cli, gen_cli, tipoDoc_cli,
                                                             nrDoc_cli,  tel_cli, email_cli, dir_cli)
        {
            this.ID_Cargo = id_cargo;
            this.ID_Personal = id_per;
            this.Estado_Empleado = estado_per;
        }
        public void Actualizar(Cargo id_carg, string estado_pers)
        {
            
            ID_Cargo = id_carg;
            Estado_Empleado = estado_pers;
        }
        public void Anular()
        {
            Estado_Empleado = "INACTIVO";
        }
    }
}
