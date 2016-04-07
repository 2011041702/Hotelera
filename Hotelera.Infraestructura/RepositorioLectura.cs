using System;
using System.Collections.Generic;
using System.Linq;
using Hotelera.Dominio;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Hotelera.Infraestructura
{
    public class RepositorioLectura<T> : IRepositorioLectura<T> where T : class
    {
        public IDbSet<T> Entidad { get; set; }
        public RepositorioLectura(HoteleraContexto ao_contexto)
        {
            this.Entidad = ao_contexto.Set<T>();
        }
        public RepositorioLectura()
            : this(new HoteleraContexto("HotelConexion"))
        {
            //this.Entidad = System.Reflection.Assembly.GetAssembly(typeof(C)).CreateInstance(typeof(C));
        }
        public T ObtenerPorCodigo(params object[] ao_llaves)
        {
            return Entidad.Find(ao_llaves);
        }

        public IList<T> ObtenerPorExpresion(System.Linq.Expressions.Expression<Func<T, bool>> ao_llaves, string as_incluir, byte aby_limite)
        {
            return Entidad.Where(ao_llaves).ToList();
        }

        public IQueryable<T> Listar()
        {
            return Entidad;
        }
    }
}