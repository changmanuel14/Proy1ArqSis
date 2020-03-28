using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Models;
using System.Collections;


namespace BusinessLogicLayer
{
    public class ClassEdificio
    {
        public IEnumerable ListarEdificios()
        {
            RepositorioGenerico<Edificio> REP = new RepositorioGenerico<Edificio>();
            return REP.ListarTodo();
        }//fin listar edificios

        public IEnumerable BuscaEdificio(string nombre)
        {
            RepositorioGenerico<Edificio> REP = new RepositorioGenerico<Edificio>();
            return REP.ListarConFiltro(n => n.nombre_edificio == nombre).ToList();
        }//fin BuscaEdificio
        public IEnumerable BuscarEdificioPorId(int id)
        {
            RepositorioGenerico<Edificio> REP = new RepositorioGenerico<Edificio>();
            return REP.ListarConFiltro(x => x.EdificioId == id).ToList();
        }

        /// <summary>
        /// Agrega un nuevo registro de edificio.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="observacion"></param>
        /// <returns></returns>
        public string NuevoEdificio(string nombre, string observacion)
        {
            RepositorioGenerico<Edificio> REP = new RepositorioGenerico<Edificio>();
            string respuesta = "";
            try
            {
                IEnumerable busca = BuscaEdificio(nombre);
                if (busca.Cast<object>().Any())
                    respuesta = "Error: Ya existe el edificio.";
                else
                {
                    Edificio EDF = new Edificio();
                    EDF.nombre_edificio = nombre;
                    EDF.observacion = observacion;
                    EDF.estado_edificio = true;
                    respuesta = REP.Agregar(EDF);
                }
            }
            catch (Exception ex)
            {
                respuesta = "Error al grabar: " + ex.Message;
                throw;
            }
            return respuesta;
        }//fin nuevo edificio

        public string EditarEdificio(Edificio EDF)
        {
            string resultado = "";

            RepositorioGenerico<Edificio> REP = new RepositorioGenerico<Edificio>();
            try
            {
                IEnumerable busca = BuscaEdificio(EDF.nombre_edificio);
                if (busca.Cast<object>().Count() > 1)
                    resultado = "Error: El edificio ya existe.";
                else
                    resultado = REP.Editar(EDF);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }//fin Editar Edificio

        public string EliminarEdificio(Edificio Edi)
        {
            string resultado = "";

            RepositorioGenerico<Edificio> REP = new RepositorioGenerico<Edificio>();
            try
            {
                resultado = REP.Eliminar(Edi);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }
    }
}
