﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Hotelera.Dominio
{
    public interface IRepositorioLectura<T>
    {
        T ObtenerPorCodigo(params object[] ao_llaves);
        IQueryable<T> Listar();
        IList<T> ObtenerPorExpresion(Expression<Func<T, bool>> ao_llaves = null, string as_incluir = null, byte aby_limite = 0);
    }
}
