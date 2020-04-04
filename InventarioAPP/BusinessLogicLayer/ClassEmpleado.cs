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
    public class ClassEmpleado
    {
        public IEnumerable ListarEmpleados()
        {
            RepositorioGenerico<Empleado> REP = new RepositorioGenerico<Empleado>();
            return REP.ListarTodo();
        }//fin Listar Categorias

        public IEnumerable BuscaEmpleado(string nombre)
        {
            RepositorioGenerico<Empleado> REP = new RepositorioGenerico<Empleado>();
            return REP.ListarConFiltro(n => n.nombres_empleado == nombre).ToList();
        }//fin BuscaCategoria

        public IEnumerable BuscarEmpleadoPorId(int id)
        {
            RepositorioGenerico<Empleado> REP = new RepositorioGenerico<Empleado>();
            return REP.ListarConFiltro(x => x.EmpleadoId == id).ToList();
        }

        public string NuevoEmpleado(string nombre, string apellidos, string direccion, string telefono, 
            string cui, DateTime fecha_nacimiento)
        {
            RepositorioGenerico<Empleado> REP = new RepositorioGenerico<Empleado>();
            string respuesta = "";
            try
            {
                IEnumerable busca = BuscaEmpleado(nombre);
                if (busca.Cast<object>().Any())
                    respuesta = "Error: Ya existe el empleado.";
                else
                {
                    Empleado Emp = new Empleado();
                    Emp.nombres_empleado = nombre;
                    Emp.apellidos_empleado = apellidos;
                    Emp.direccion_empleado = direccion;
                    Emp.telefono_empleado = telefono;
                    Emp.cui_empleado = cui;
                    Emp.fecha_nacimiento = fecha_nacimiento;
                    Emp.estado_empleado = true;
                    respuesta = REP.Agregar(Emp);
                }
            }
            catch (Exception ex)
            {
                respuesta = "Error al grabar: " + ex.Message;
                throw;
            }
            return respuesta;
        }//fin nueva categoria

        public string EditarEmpleado(Empleado Emp)
        {
            string resultado = "";

            RepositorioGenerico<Empleado> REP = new RepositorioGenerico<Empleado>();
            try
            {
                IEnumerable busca = BuscaEmpleado(Emp.nombres_empleado);
                if (busca.Cast<object>().Count() > 1)
                    resultado = "Error: El empleado ya existe.";
                else
                    resultado = REP.Editar(Emp);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }

        public string EliminarEmpleado(Empleado Emp)
        {
            string resultado = "";

            RepositorioGenerico<Empleado> REP = new RepositorioGenerico<Empleado>();
            try
            {
                resultado = REP.Eliminar(Emp);
            }
            catch (Exception ex)
            {
                resultado = "Error" + ex.Message;
            }

            return resultado;
        }

        public string NuevoEmpleadoUsuario(Usuario user, Empleado emp)
        {
            string respuesta = "";

            try
            {
                ClassUsuario cUser = new ClassUsuario();
                IEnumerable busca = cUser.BuscaUsuarioPorUser(user.userName);

                if (busca.Cast<object>().Any())
                    respuesta = "Error: Ya existe el usuario.";
                else
                {
                    RepositorioGenerico<Empleado> REPE = new RepositorioGenerico<Empleado>();
                    RepositorioGenerico<Usuario> REPU = new RepositorioGenerico<Usuario>();
                    Password pwd = new Password();
                    //Datos Empleado
                    emp.estado_empleado = true;
                    REPE.Agregar(emp);
                    REPE = null;
                    //Datos Usuario
                    user.password = pwd.Encrypt(user.password);
                    user.EmpleadoId = UltimoEmpleadoId();
                    REPU.Agregar(user);
                }
            }
            catch(Exception ex)
            {

            }

            return respuesta;
        }

        private int UltimoEmpleadoId()
        {
            RepositorioGenerico<Empleado> REP = new RepositorioGenerico<Empleado>();
            var lista = REP.ListarTodo().OrderByDescending(x => x.EmpleadoId).Take(1);
            int ID = 0;
            foreach (Empleado emp in lista)
            {
                ID = emp.EmpleadoId;
            }
            return ID;
        }
    }
}
