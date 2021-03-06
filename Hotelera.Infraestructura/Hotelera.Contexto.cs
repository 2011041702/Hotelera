﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Hotelera.Dominio;

namespace Hotelera.Infraestructura
{
    public class HoteleraContexto : DbContext, IDisposable
    {
        //ERRORES
        //int A;
        public HoteleraContexto(string Conexion) : base("Conexion")
        {
            Database.SetInitializer<HoteleraContexto>(new InicializadorBD());
        }
        public HoteleraContexto() : base("HotelConexion")
        {
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Persona>().HasKey(k => k.NumeroDocumentoPersona);
            modelBuilder.Entity<Empleado>().HasKey(k => k.ID_Personal);
            modelBuilder.Entity<Cargo>().HasKey(k => k.ID_Cargo);
            ///mapera llaves foraneas
            /// identity
        }
    }
}
