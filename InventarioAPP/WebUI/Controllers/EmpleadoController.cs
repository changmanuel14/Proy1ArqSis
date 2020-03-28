using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;
using Models;

namespace WebUI.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            ClassEmpleado Logica = new ClassEmpleado();
            var Info = Logica.ListarEmpleados();
            return View(Info);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(string name)
        {
            ClassEmpleado Logica = new ClassEmpleado();
            var Info = (List<Empleado>)Logica.BuscaEmpleado(name);
            return View(Info[0]);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                ClassEmpleado Logica = new ClassEmpleado();
                string respuesta = Logica.NuevoEmpleado(collection["nombres_empleado"], 
                    collection["apellidos_empleado"], collection["direccion_empleado"], collection["telefono_empleado"],
                    collection["cui_empleado"],Convert.ToDateTime(collection["fecha_nacimiento"]));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            ClassEmpleado Lg = new ClassEmpleado();
            var info = (List<Empleado>)Lg.BuscarEmpleadoPorId(id);
            return View(info[0]);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                ClassEmpleado Logica = new ClassEmpleado();
                Empleado Emp = new Empleado();
                Emp.nombres_empleado = collection["nombres_empleado"];
                Emp.apellidos_empleado = collection["apellidos_empleado"];
                Emp.direccion_empleado = collection["direccion_empleado"];
                Emp.telefono_empleado = collection["telefono_empleado"];
                Emp.cui_empleado = collection["cui_empleado"];
                Emp.fecha_nacimiento = Convert.ToDateTime(collection["fecha_nacimiento"]);
                string aux = collection["estado_empleado"];
                if (aux != "false")
                {
                    Emp.estado_empleado = true;
                }
                Logica.EditarEmpleado(Emp);


                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ClassEmpleado Logica = new ClassEmpleado();
                Empleado Emp = new Empleado();
                Emp.EmpleadoId = id;
                Logica.EliminarEmpleado(Emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}