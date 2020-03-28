using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Models;

namespace BusinessLogicLayer
{
    public class ClassUbicacion
    {
        public IEnumerable ListarUbicaciones()
        {
            RepositorioGenerico<Ubicacion> REP = new RepositorioGenerico<Ubicacion>();
            return REP.ListarTodo();
        }//fin listar ubicaciones

        public IEnumerable BuscaUbicacion(string nombre)
        {
            RepositorioGenerico<Ubicacion> REP = new RepositorioGenerico<Ubicacion>();
            return REP.ListarConFiltro(n => n.nombre_ubicacion == nombre).ToList();
        }//fin BuscaUbicacion

        public IEnumerable BuscarUbicacionPorId(int id)
        {
            RepositorioGenerico<Ubicacion> REP = new RepositorioGenerico<Ubicacion>();
            return REP.ListarConFiltro(x => x.UbicacionId == id).ToList();
        }

        public string NuevaUbicacion(string nombre, string observacion, short edificioID)
        {
            RepositorioGenerico<Ubicacion> REP = new RepositorioGenerico<Ubicacion>();
            string respuesta = "";
            try
            {
                IEnumerable busca = BuscaUbicacion(nombre);
                if (busca.Cast<object>().Any())
                    respuesta = "Error: Ya existe la ubicación.";
                else
                {
                    Ubicacion UB = new Ubicacion();
                    UB.nombre_ubicacion = nombre;
                    UB.observacion = observacion;
                    UB.estado_ubicacion = true;
                    UB.EdificioId = edificioID;
                    respuesta = REP.Agregar(UB);
                }
            }
            catch (Exception ex)
            {
                respuesta = "Error al grabar: " + ex.Message;
                throw;
            }
            return respuesta;
        }//fin nueva ubicacion

        public string EditarUbicacion(Ubicacion UB)
        {
            string resultado = "";

            RepositorioGenerico<Ubicacion> REP = new RepositorioGenerico<Ubicacion>();
            try
            {
                IEnumerable busca = BuscaUbicacion(UB.nombre_ubicacion);
                if (busca.Cast<object>().Count() > 1)
                    resultado = "Error: La ubicación ya existe.";
                else
                    resultado = REP.Editar(UB);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }//fin Editar Ubicación

        public string EliminarUbicacion(Ubicacion Ubi)
        {
            string resultado = "";

            RepositorioGenerico<Ubicacion> REP = new RepositorioGenerico<Ubicacion>();
            try
            {
                resultado = REP.Eliminar(Ubi);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }
    }
}
