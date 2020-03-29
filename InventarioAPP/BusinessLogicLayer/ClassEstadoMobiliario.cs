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
    public class ClassEstadoMobiliario
    {
        public IEnumerable ListarEstadoMobiliario()
        {
            RepositorioGenerico<Estadomobiliario> REP = new RepositorioGenerico<Estadomobiliario>();
            return REP.ListarTodo();
        }//fin listar estado mobiliario

        public IEnumerable BuscaEstadoMobiliarioPorId(int id)
        {
            RepositorioGenerico<Estadomobiliario> REP = new RepositorioGenerico<Estadomobiliario>();
            return REP.ListarConFiltro(x => x.EstadomobiliarioId == id).ToList();
        }//fin BuscaEdificio
    }
}
