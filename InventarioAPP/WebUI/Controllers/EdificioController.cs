using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;
using Models;

namespace WebUI.Controllers
{
    public class EdificioController : Controller
    {
        // GET: Edificio
        public ActionResult Index()
        {
            ClassEdificio Logica = new ClassEdificio();
            var Info = Logica.ListarEdificios();
            return View(Info);
        }
        public ActionResult Details(string name)
        {
            ClassEdificio Logica = new ClassEdificio();
            var Info = (List<Edificio>)Logica.BuscaEdificio(name);
            return View(Info[0]);
        }

        // GET: Edificio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Edificio/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                ClassEdificio Logica = new ClassEdificio();
                string respuesta = Logica.NuevoEdificio(collection["nombre_edificio"], collection["observacion"]);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Edificio/Edit/5
        public ActionResult Edit(int id)
        {
            ClassEdificio Lg = new ClassEdificio();
            var info = (List<Edificio>)Lg.BuscarEdificioPorId(id);
            return View(info[0]);
        }

        // POST: Edificio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                ClassEdificio Logica = new ClassEdificio();
                Edificio Edi = new Edificio();
                Edi.EdificioId = id;
                Edi.nombre_edificio= collection["nombre_edificio"];
                Edi.observacion = collection["observacion"];
                string aux = collection["estado_edificio"];
                if (aux != "false")
                {
                    Edi.estado_edificio = true;
                }
                Logica.EditarEdificio(Edi);


                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Edificio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Edificio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ClassEdificio Logica = new ClassEdificio();
                Edificio Edi = new Edificio();
                Edi.EdificioId = id;
                Logica.EliminarEdificio(Edi);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
