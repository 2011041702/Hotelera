using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotelera.Dominio;
using Hotelera.Infraestructura;

namespace Hotelera.PruebasUnitarias
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Cargo cargo = new Cargo(3,"Recepcionista","Encargado de la atencion del huesped",899,"aceptado");
            //Personal objempleado = new Personal(cargo,5, "normal", "Lucas", "Vasquez", "Masculino", "dni", "5555555", "052-455435", "luis.v@hotmail.com", "Ave Jorge Basade #123");
            var lo_rep_cargo = new RepositorioGenerico<Cargo>();
            //lo_rep_cargo.Adicionar(cargo);
            //lo_rep_cargo.GuardarCambios();
            /*using (var lo_contexto = new HoteleraContexto())
            {
                lo_contexto.Empleados.Add(objempleado);
            lo_contexto.Cargos.Add(cargo);
                lo_contexto.SaveChanges();
            }*/
            var lo_cargos = lo_rep_cargo.ObtenerPorExpresion(p=>p.Nombre_Cargo == "Recepcionista");
            Assert.IsTrue(lo_cargos.Count == 3);
        }
    }
}
