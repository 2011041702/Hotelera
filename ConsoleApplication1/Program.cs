using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotelera.Dominio;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo monovolumen = new Monovolumen();
            //Vehiculo berlina = new Berlina();
            Servicios servicioBasico = new ServicioBasico();
            Servicios servicioPremium = new ServicioPremium();

            //Se nos ofrece una versión “básica” de nuestros objetos, 
            //que aún no han sido decorados. Probemos a decorar Servicio Basico 
            //añadiéndole el agregado Servicio a la Habitacion:

            servicioBasico = new ServicioHabitacion(servicioBasico);

            //ahora añadimos mas servicios para Preium
            servicioPremium = new Tvcable(servicioPremium);
            servicioPremium = new ServicioHabitacion(servicioPremium);
            servicioPremium = new Transporte(servicioPremium);
            servicioPremium = new BarSalon(servicioPremium);
            servicioPremium = new Lavanderia(servicioPremium);

            MostrarCaracteristicas(servicioBasico);

            MostrarCaracteristicas(servicioPremium);
            Console.ReadLine();
        }

        private static void MostrarCaracteristicas(Servicios v)
        {
            Console.WriteLine(string.Format(" {0} \n\t- \n\tCosto de s./ {1} \n",
                                            v.descripcion(),
                                            v.calcularCosto()
                                            ));
        }
    }
}
