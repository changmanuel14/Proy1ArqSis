using DataAccessLayer;
using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ClassUsuario
    {
        public IEnumerable ListarUsuarios()
        {
            RepositorioGenerico<Usuario> REP = new RepositorioGenerico<Usuario>();
            return REP.ListarTodo();
        }//fin Listar Usuarios

        public IEnumerable BuscaUsuarioPorId(int id)
        {
            RepositorioGenerico<Usuario> REP = new RepositorioGenerico<Usuario>();
            return REP.ListarConFiltro(x => x.UsuarioId == id).ToList();
        }//fin BuscaUsuarioPorId

        public IEnumerable BuscaUsuarioPorUser(string user)
        {
            RepositorioGenerico<Usuario> REP = new RepositorioGenerico<Usuario>();
            return REP.ListarConFiltro(x => x.userName == user).ToList();
        }//fin BuscaUsuarioPorUser

        public IEnumerable BuscaUsuarioPorUserPWD(string user, string pwd)
        {
            RepositorioGenerico<Usuario> REP = new RepositorioGenerico<Usuario>();
            return REP.ListarConFiltro(x => x.userName == user && x.password == pwd).ToList();
        }//fin BuscaUsuarioPorUserPWD

        public string NuevoUsuario(string nombre, string pwd, int empleadoId, int tipousuarioId)
        {
            RepositorioGenerico<Usuario> REP = new RepositorioGenerico<Usuario>();
            DataAccess data = new DataAccess();
            string respuesta = "";
            try
            {
                IEnumerable busca = BuscaUsuarioPorUser(nombre);
                if (busca.Cast<object>().Any())
                    respuesta = "Error: Ya existe el nombre de usuario.";
                else
                {
                    //Expression<Func<Usuario, byte[]>> filtro = (x =>  );

                    Usuario usuario = new Usuario();
                    usuario.userName = nombre;
                    usuario.password = null;
                    usuario.TipousuarioId = tipousuarioId;
                    usuario.EmpleadoId = empleadoId;
                    respuesta = REP.Agregar(usuario);
                }
            }
            catch (Exception ex)
            {
                respuesta = "Error al grabar: " + ex.Message;
                throw;
            }
            return respuesta;
        }//fin nuevo usuario

        public string EditarUsuario(Usuario user)
        {
            string resultado = "";

            RepositorioGenerico<Usuario> REP = new RepositorioGenerico<Usuario>();
            try
            {
                IEnumerable busca = BuscaUsuarioPorUser(user.userName);
                if (busca.Cast<object>().Count() > 1)
                    resultado = "Error: Ya existe el nombre de usuario.";
                else
                    resultado = REP.Editar(user);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }

        public string EliminarUsuario(Usuario user)
        {
            string resultado = "";

            RepositorioGenerico<Usuario> REP = new RepositorioGenerico<Usuario>();
            try
            {
                resultado = REP.Eliminar(user);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }
    }
}
