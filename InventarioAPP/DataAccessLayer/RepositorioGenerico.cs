using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;
using Models;

namespace DataAccessLayer
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T:class
    {
        inventarioDBEntities contexto;//representacion de objetos de base de datos

        public IQueryable<T> ListarTodo()
        {
            IQueryable<T> respuesta;
            using (contexto = new inventarioDBEntities())
            {
                respuesta = contexto.Set<T>().ToList().AsQueryable();
            }
            return respuesta;
        }

        public string Agregar(T NuevaEntidad)
        {
            string mensaje = "";
            if (NuevaEntidad == null)
                mensaje = "Error: Datos Vacíos.";
            else
            {
                using (contexto = new inventarioDBEntities())
                {
                    var dbSet = contexto.Set<T>();
                    dbSet.Add(NuevaEntidad);
                    contexto.SaveChanges();
                    mensaje = "Se ha grabado el nuevo registro.";
                }//fin using
            }//fin else
            return mensaje;
        }//fin agregar

        public IQueryable<T> ListarConFiltro(Expression<Func<T, bool>> filtro)
        {
            IQueryable<T> respuesta;
            using (contexto = new inventarioDBEntities())
            {
                DbQuery<T> busca = contexto.Set<T>();
                respuesta = busca.Where(filtro).ToList().AsQueryable();
            }
            return respuesta;
        }//fin ListarConFiltro

        public string Editar(T Entidad)
        {
            string mensaje = "";
            if (Entidad == null)
                mensaje = "Error: Datos vacíos.";
            else
            {
                using (contexto = new inventarioDBEntities())
                {
                    var dbSet = contexto.Set<T>();
                    dbSet.Attach(Entidad);
                    contexto.Entry(Entidad).State = EntityState.Modified;
                    contexto.SaveChanges();
                    mensaje = "Datos Actualizados.";
                }//fin del using
            }//fin del else
            return mensaje;
        }//fin Editar

        public string Eliminar(T Entidad)
        {
            string mensaje = "";
            if (Entidad == null)
                mensaje = "Error: Datos vacíos.";
            else
            {
                using (contexto = new inventarioDBEntities())
                {
                    var dbSet = contexto.Set<T>();
                    dbSet.Attach(Entidad);
                    contexto.Entry(Entidad).State = EntityState.Deleted;
                    contexto.SaveChanges();
                    mensaje = "Datos Actualizados.";
                }//fin del using
            }//fin del else
            return mensaje;
        }//fin Editar
    }
}
