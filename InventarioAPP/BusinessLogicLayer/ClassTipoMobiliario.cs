using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Collections;
using Models;

namespace BusinessLogicLayer
{
    public class ClassTipoMobiliario
    {
        public IEnumerable ListarTipoMobiliario()
        {
            RepositorioGenerico<Tipomobiliario> REP = new RepositorioGenerico<Tipomobiliario>();
            return REP.ListarTodo();
        }//fin listar tipo mobiliario

        public IEnumerable BuscaTipoMobiliario(string nombre)
        {
            RepositorioGenerico<Tipomobiliario> REP = new RepositorioGenerico<Tipomobiliario>();
            return REP.ListarConFiltro(n => n.descripcion == nombre).ToList();
        }//fin BuscaCategoria

        public IEnumerable BuscarTipoMobiliarioPorId(int id)
        {
            RepositorioGenerico<Tipomobiliario> REP = new RepositorioGenerico<Tipomobiliario>();
            return REP.ListarConFiltro(x => x.TipomobiliarioId == id).ToList();
        }

        public string NuevoTipoMobiliario(string nombre, int control_serie, int CategoriaId)
        {
            RepositorioGenerico<Tipomobiliario> REP = new RepositorioGenerico<Tipomobiliario>();
            string respuesta = "";
            try
            {
                IEnumerable busca = BuscaTipoMobiliario(nombre);
                if (busca.Cast<object>().Any())
                    respuesta = "Error: Ya existe el TipoMobiliario.";
                else
                {
                    Tipomobiliario TiM = new Tipomobiliario();
                    TiM.descripcion = nombre;
                    TiM.control_serie = control_serie;
                    TiM.estado_tipomobiliario = true;
                    TiM.CategoriaId = CategoriaId;
                    respuesta = REP.Agregar(TiM);
                }
            }
            catch (Exception ex)
            {
                respuesta = "Error al grabar: " + ex.Message;
                throw;
            }
            return respuesta;
        }//fin nueva TipoMobiliario

        public string EditarTipoMobiliario(Tipomobiliario TiM)
        {
            string resultado = "";

            RepositorioGenerico<Tipomobiliario> REP = new RepositorioGenerico<Tipomobiliario>();
            try
            {
                IEnumerable busca = BuscaTipoMobiliario(TiM.descripcion);
                if (busca.Cast<object>().Count() > 1)
                    resultado = "Error: El Tipo Mobiliario ya existe.";
                else
                    resultado = REP.Editar(TiM);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }

        public string EliminarTipoMobiliario(Tipomobiliario TiM)
        {
            string resultado = "";

            RepositorioGenerico<Tipomobiliario> REP = new RepositorioGenerico<Tipomobiliario>();
            try
            {
                resultado = REP.Eliminar(TiM);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }

        public static implicit operator ClassTipoMobiliario(ClassEdificio v)
        {
            throw new NotImplementedException();
        }
    }
}
