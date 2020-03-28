using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DataAccessLayer
{
    public interface IRepositorioGenerico<T> where T:class
    {
        IQueryable<T> ListarTodo();

        string Agregar(T NuevaEntidad);

        IQueryable<T> ListarConFiltro(Expression<Func<T, bool>> filtro);

        string Editar(T Entidad);
    }
}
