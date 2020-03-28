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
    public class ClassCategoria
    {
        public IEnumerable ListarCategorias()
        {
            RepositorioGenerico<Categoria> REP = new RepositorioGenerico<Categoria>();
            return REP.ListarTodo();
        }//fin Listar Categorias

        public IEnumerable ListarTiposCategorias()
        {
            RepositorioGenerico<Tipomobiliario> REP = new RepositorioGenerico<Tipomobiliario>();
            return REP.ListarTodo();
        }//fin de ListarTiposCategoria

        public IEnumerable BuscaCategoria(string nombre)
        {
            RepositorioGenerico<Categoria> REP = new RepositorioGenerico<Categoria>();
            return REP.ListarConFiltro(n => n.nombre_categoria == nombre).ToList();
        }//fin BuscaCategoria

        public IEnumerable BuscarCategoriaPorId(int id)
        {
            RepositorioGenerico<Categoria> REP = new RepositorioGenerico<Categoria>();
            return REP.ListarConFiltro(x => x.CategoriaId == id).ToList();
        }

        public string NuevaCategoria(string nombre)
        {
            RepositorioGenerico<Categoria> REP = new RepositorioGenerico<Categoria>();
            string respuesta = "";
            try
            {
                IEnumerable busca = BuscaCategoria(nombre);
                if (busca.Cast<object>().Any())
                    respuesta = "Error: Ya existe la categoria.";
                else
                {
                    Categoria CAT = new Categoria();
                    CAT.nombre_categoria = nombre;
                    CAT.fecha_creacion = DateTime.Now;
                    CAT.estado_categoria = true;
                    respuesta = REP.Agregar(CAT);
                }
            }
            catch (Exception ex)
            {
                respuesta = "Error al grabar: " + ex.Message;
                throw;
            }
            return respuesta;
        }//fin nueva categoria

        public string EditarCategoria(Categoria Cat)
        {
            string resultado = "";

            RepositorioGenerico<Categoria> REP = new RepositorioGenerico<Categoria>();
            try
            {
                IEnumerable busca = BuscaCategoria(Cat.nombre_categoria);
                if (busca.Cast<object>().Count() > 1)
                    resultado = "Error: La categoría ya existe.";
                else
                    resultado = REP.Editar(Cat);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }

        public string EliminarCategoria(Categoria Cat)
        {
            string resultado = "";

            RepositorioGenerico<Categoria> REP = new RepositorioGenerico<Categoria>();
            try
            {
                resultado = REP.Eliminar(Cat);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }
    }
}
