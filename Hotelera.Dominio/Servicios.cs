using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public abstract class Servicios
    {
        public int ID_Servicio { get; private set; }
        public string Nombre_Servicio { get; private set; }     
        public string Descripcion_Servicio { get; private set; }
        
        public decimal Precio_Servicio { get; private set; }
        public string Estado_Servicio { get; private set; }
        
        public Servicios()
        {
            this.Descripcion_Servicio = "Presenta servicios generales";
            //this.Precio_Servicio = 20;
        }
        public void Actualizar(int id_serv,string nomb_serv, string descrip_serv, decimal precio_serv, string estado_serv)
        {
            ID_Servicio = id_serv;
            Nombre_Servicio = nomb_serv;
            Descripcion_Servicio = descrip_serv;
            Precio_Servicio = precio_serv;
            Estado_Servicio = estado_serv;
        }
        public void Anular()
        {
            Estado_Servicio = "ELIMINADO";
        }

        public virtual decimal calcularCosto()
        {
            return Precio_Servicio;
        }
        public virtual String descripcion()
        {
            return Descripcion_Servicio;
        }

    }
}
