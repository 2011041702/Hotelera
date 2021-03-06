﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelera.Dominio
{
    public class Cliente : Persona
    {
        
        public int ID_Cliente { get; private set; }
        public string Estado_Cliente { get; private set; }
        public virtual Persona Persona { get; private set; }
        /// <summary>
        /// Éste metodo nos servirá para agregar a los Clientes
        /// </summary>
        /// <param name="id_cli">Id del cliente</param>
        /// <param name="estado_cli">Estado del Cliente </param>
        /// <param name="nombre_cli">Nombre del Cliente</param>
        /// <param name="apel_cli">Apellido del Cliente</param>
        /// <param name="gen_cli">Genero del Cliente</param>
        /// <param name="tipoDoc_cli">TipDocumento del Cliente</param>
        /// <param name="nrDoc_cli">NrDocumento del Cliente</param>
        /// <param name="tel_cli">Telefono del Cliente</param>
        /// <param name="email_cli">Email del Cliente</param>
        /// <param name="dir_cli">Direccion del Cliente</param>
        public Cliente(int id_cli,string estado_cli, string nombre_cli, string apel_cli, string gen_cli, string tipoDoc_cli,
                                                            string nrDoc_cli, string tel_cli, string email_cli, string dir_cli) 
                                                            :base( nombre_cli, apel_cli, gen_cli, tipoDoc_cli,
                                                             nrDoc_cli,  tel_cli, email_cli, dir_cli)
        {
            this.ID_Cliente = id_cli;
            this.Estado_Cliente = estado_cli;
        }
        /// <summary>
        ///  Para Actualizar la informacioon de un Cliente
        /// </summary>
        /// <param name="id_cli">Id del cliente</param>
        /// <param name="nomb_cli">Nombre del Cliente</param>
        /// <param name="ape_cli">Apellido del Cliente</param>
        /// <param name="doc_cli">Documento del Cliente</param>
        /// <param name="cel_cli">Celular Cliente</param>
        /// <param name="email_cli">Email del Cliente</param>
        /// <param name="estado_cli">Estado del Cliente</param>
        public void Actualizar(int id_cli, string nomb_cli, string ape_cli, int doc_cli, string cel_cli, string email_cli, string estado_cli)
        {
            ID_Cliente = id_cli;
            ///Nombre_Cliente = nomb_cli;
            ///Apellido_Cliente = ape_cli;
            ///Documento_Cliente = doc_cli;
            ///Celular_Cliente = cel_cli;
            ///Email_Cliente = email_cli;
            Estado_Cliente = estado_cli;
        }
        /// <summary>
        /// Cancelar algun Servicio
        /// </summary>
        public void Bloquear()
        {
            Estado_Cliente = "INACTIVO";
        }
        public void solicitarServicio() { }
        public void checkarHabitacionesDisponibles() { }
        public void solicitarExtension() { }
    }
}
