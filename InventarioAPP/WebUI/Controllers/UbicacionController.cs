using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;
using Models;

namespace WebUI.Controllers
{
    public class UbicacionController : Controller
    {
        // GET: Ubicacion
        public ActionResult Index()
        {
            ClassUbicacion Logica = new ClassUbicacion();
            var Info = Logica.ListarUbicaciones();
            return View(Info);
        }

        // GET: Ubicacion/Details/5
        public ActionResult Details(string name)
        {
            ClassUbicacion Logica = new ClassUbicacion();
            var Info = (List<Ubicacion>)Logica.BuscaUbicacion(name);
            return View(Info[0]);
        }

        // GET: Ubicacion/Create
        public ActionResult Create()
        {
            ClassEdificio ListaE = new ClassEdificio();
            var InfoE = ListaE.ListarEdificios();
            ViewBag.Edificio = new SelectList(InfoE, "EdificioId", "nombre_edificio");
            return View();
        }

        // POST: Ubicacion/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                ClassUbicacion Logica = new ClassUbicacion();
                string respuesta = Logica.NuevaUbicacion(collection["nombre_ubicacion"], collection["observacion"], Convert.ToInt16(collection["EdificioId"]));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ubicacion/Edit/5
        public ActionResult Edit(int id)
        {
            ClassUbicacion Lg = new ClassUbicacion();
            ClassEdificio ListaE = new ClassEdificio();
            var InfoE = ListaE.ListarEdificios();
            ViewBag.Edificio = new SelectList(InfoE, "EdificioId", "nombre_edificio");
            var info = (List<Ubicacion>)Lg.BuscarUbicacionPorId(id);
            return View(info[0]);
        }

        // POST: Ubicacion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                ClassUbicacion Logica = new ClassUbicacion();
                Ubicacion Ubi = new Ubicacion();
                Ubi.UbicacionId = id;
                string aux = collection["estado_ubicacion"];
                if (aux != "false")
                {
                    Ubi.estado_ubicacion = true;
                }
                Ubi.nombre_ubicacion = collection["nombre_ubicacion"];
                Ubi.observacion = collection["observacion"];
                Ubi.EdificioId = Convert.ToInt16(collection["EdificioId"]);

                Logica.EditarUbicacion(Ubi);


                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Ubicacion/Delete/5
        public ActionResult Delete(int id)
        {
            ClassUbicacion Logica = new ClassUbicacion();
            var Info = (List<Ubicacion>)Logica.BuscarUbicacionPorId(id);
            return View(Info[0]);
        }

        // POST: Ubicacion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ClassUbicacion Logica = new ClassUbicacion();
                Ubicacion Ubi = new Ubicacion();
                Ubi.UbicacionId = id;
                Logica.EliminarUbicacion(Ubi);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}