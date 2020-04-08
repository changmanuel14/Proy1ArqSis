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
    public class ClassMobiliario
    {
        public IEnumerable ListarMobiliario()
        {
            RepositorioGenerico<Mobiliario> REP = new RepositorioGenerico<Mobiliario>();
            return REP.ListarTodo();
        }//fin listar mobiliario

        public IEnumerable BuscaMobiliario(string numeroS)
        {
            RepositorioGenerico<Mobiliario> REP = new RepositorioGenerico<Mobiliario>();
            return REP.ListarConFiltro(n => n.numero_serie == numeroS).ToList();
        }//fin BuscaEdificio

        public IEnumerable BuscaMobiliarioPorId(int id)
        {
            RepositorioGenerico<Mobiliario> REP = new RepositorioGenerico<Mobiliario>();
            return REP.ListarConFiltro(x => x.MobiliarioId == id).ToList();
        }//fin BuscaEdificio

        public string NuevoMobiliario(int TipoMobiliarioID, 
            int UbicacionID, string descripcion, string numeroS, string observacion)
        {
            RepositorioGenerico<Mobiliario> REP = new RepositorioGenerico<Mobiliario>();
            string respuesta = "";
            try
            {
                IEnumerable busca = BuscaMobiliario(numeroS);
                if (busca.Cast<object>().Any())
                    respuesta = "Error: Ya existe el mobiliario.";
                else
                {
                    Mobiliario MB = new Mobiliario();
                    MB.EstadomobiliarioId = 1;
                    MB.TipomobiliarioId = TipoMobiliarioID;
                    MB.UbicacionId = UbicacionID;
                    MB.descripcion_mobiliario = descripcion;
                    MB.fecha_creacion = DateTime.Now;
                    MB.numero_serie = numeroS;
                    MB.observacion = observacion;
                    respuesta = REP.Agregar(MB);
                }
            }
            catch (Exception ex)
            {
                respuesta = "Error al grabar: " + ex.Message;
                throw;
            }
            return respuesta;
        }//fin nuevo mobiliario

        public string EditarMobiliario(Mobiliario MB)
        {
            string resultado = "";

             RepositorioGenerico<Mobiliario> REP = new RepositorioGenerico<Mobiliario>();
            try
            {
                IEnumerable busca = BuscaMobiliario(MB.numero_serie);
                if (busca.Cast<object>().Count() > 1)
                    resultado = "Error: El mobiliario ya existe.";
                else
                    resultado = REP.Editar(MB);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }//fin Editar Mobiliario

        public string EliminarMobiliario(Mobiliario Mob)
        {
            string resultado = "";

            RepositorioGenerico<Mobiliario> REP = new RepositorioGenerico<Mobiliario>();
            try
            {
                resultado = REP.Eliminar(Mob);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }

       /* public IEnumerable informacion1()
        {
            try
            {
                inventarioDBEntities context = new inventarioDBEntities();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/
    }
}
