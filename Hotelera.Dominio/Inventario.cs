﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Inventario
    {
        public int ID_Inventario { get; set; }
        public virtual Proveedor ID_Pro { get; set; }
        public string Estado_Inventario { get; set; }

        public static Inventario Guardar(Proveedor id_prov,string estado_inv)
        {
            return new Inventario()
            {
                ID_Pro = id_prov,
                Estado_Inventario = estado_inv
            };
        }
        public void Modificar(int id_inven,Proveedor id_prov, string estado_inv)
        {
            ID_Inventario = id_inven;
            ID_Pro = id_prov;
            Estado_Inventario = estado_inv;
        }
        public void Eliminar()
        {
            Estado_Inventario = "ELIMINADO";
        }
    }
}