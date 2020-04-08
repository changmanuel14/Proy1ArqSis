using DataAccessLayer;
using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ClassTipoUsuario
    {
        public IEnumerable ListarTiposUsuario()
        {
            RepositorioGenerico<Tipousuario> REP = new RepositorioGenerico<Tipousuario>();
            return REP.ListarTodo();
        }//fin Listar Tipos de Usuario

        public IEnumerable BuscaTipoUsuarioPorId(int id)
        {
            RepositorioGenerico<Tipousuario> REP = new RepositorioGenerico<Tipousuario>();
            return REP.ListarConFiltro(x => x.TipousuarioId == id).ToList();
        }//fin BuscaTipoUsuarioPorId

        public string[] GetUserRole(string username)
        {
            using (var context = new inventarioDBEntities())
            {
                var result = (from usuario in context.Usuario
                              join role in context.Tipousuario on usuario.TipousuarioId equals role.TipousuarioId
                              where usuario.userName == username
                              select role.nombre).ToArray();
                return result;
            }
                throw new NotImplementedException();
        }
    }
}
