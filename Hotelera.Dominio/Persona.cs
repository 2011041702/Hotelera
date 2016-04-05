using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//asignamos las librerias que vamos a usar

namespace Hotelera.Dominio
{
    
    public class Persona
    //nombre de la clase
    {

        //creamos las variables de la clase persona y las encapsulamos usando el private
        public string Nombre_Persona { get; private set; }
        public string Apellido_Persona { get; private set; }
        public string Genero_Persona { get; private set; }
        public string TipoDocumentoPersona { get; private set; }
        public string NumeroDocumentoPersona { get; private set; }
        public string Telefono_Persona { get; private set; }
        public string Email_Persona { get; private set; }
        public string Direccion_Persona { get; private set; }
        
        public Persona(string nombre_per, string apel_per,
                                        string gen_per, string tipoDoc_per, string nrDoc_per, string tel_per, string email_per, string dir_per)
        {
            //aqui se 
            this.Nombre_Persona = nombre_per;
            this.Apellido_Persona = apel_per;
            this.Genero_Persona = gen_per;
            this.TipoDocumentoPersona = tipoDoc_per;
            this.NumeroDocumentoPersona = nrDoc_per;
            this.Telefono_Persona = tel_per;
            this.Email_Persona = email_per;
            this.Direccion_Persona = dir_per;
        }
       
        
    }
    
}