using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;
using Models;

namespace WebUI.Controllers
{
    [Authorize]
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
            ClassTipoUsuario tu = new ClassTipoUsuario();
            var infoTU = tu.ListarTiposUsuario();
            ViewBag.TipoUsuario = new SelectList(infoTU, "TipousuarioId", "nombre");
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(Usuario user, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                ClassEmpleado Logica = new ClassEmpleado();
                string respuesta = Logica.NuevoEmpleadoUsuario(user, user.Empleado);
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
        public ActionResult Edit(int id, Empleado emp, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                ClassEmpleado Logica = new ClassEmpleado();
                Logica.EditarEmpleado(emp);
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
            ClassEmpleado Logica = new ClassEmpleado();
            var Info = (List<Empleado>)Logica.BuscarEmpleadoPorId(id);
            return View(Info[0]);
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