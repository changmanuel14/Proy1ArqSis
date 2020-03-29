using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;
using Models;

namespace WebUI.Controllers
{
    public class MobiliarioController : Controller
    {
        // GET: Mobiliario
        public ActionResult Index()
        {
            ClassMobiliario Logica = new ClassMobiliario();
            var Info = Logica.ListarMobiliario();
            return View(Info);
        }

        // GET: Mobiliario/Details/5
        public ActionResult Details(string name)
        {
            ClassMobiliario Logica = new ClassMobiliario();
            var Info = (List<Mobiliario>)Logica.BuscaMobiliario(name);
            return View(Info[0]);
        }

        // GET: Mobiliario/Create
        public ActionResult Create()
        {
            ClassTipoMobiliario listaTM = new ClassTipoMobiliario();
            ClassUbicacion listaU = new ClassUbicacion();
            //obtenenmos los datos para llenar los DropDown
            var InfoTM = listaTM.ListarTipoMobiliario();
            var InfoU = listaU.ListarUbicaciones();
            //Pasamos la lista de datos a la variable dinamica ViewBag
            ViewBag.TipoMobiliario = new SelectList(InfoTM, "TipomobiliarioId", "descripcion");
            ViewBag.Ubicaciones = new SelectList(InfoU, "UbicacionId", "nombre_ubicacion");
            return View();
        }

        // POST: Mobiliario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                ClassMobiliario Logica = new ClassMobiliario();
                string respuesta = Logica.NuevoMobiliario(Convert.ToInt32(collection["TipomobiliarioId"]), 
                    Convert.ToInt32(collection["UbicacionId"]),collection["descripcion_mobiliario"], 
                    collection["numero_serie"], collection["observacion"]);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mobiliario/Edit/5
        public ActionResult Edit(int id)
        {
            ClassMobiliario Lg = new ClassMobiliario();
            var info = (List<Mobiliario>)Lg.BuscaMobiliarioPorId(id);
            return View(info[0]);
        }

        // POST: Mobiliario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                ClassMobiliario Logica = new ClassMobiliario();
                Mobiliario Mob = new Mobiliario();
                Mob.MobiliarioId = id;
                Mob.EstadomobiliarioId = Convert.ToInt32(collection["EstadomobiliarioId"]);
                Mob.TipomobiliarioId = Convert.ToInt32(collection["TipomobiliarioId"]);
                Mob.UbicacionId= Convert.ToInt32(collection["UbicacionId"]);
                Mob.descripcion_mobiliario = collection["descripcion_mobiliario"];
                Mob.fecha_creacion = Convert.ToDateTime(collection["fecha_creacion"]);
                Mob.numero_serie = collection["numero_serie"];
                Mob.fecha_baja = Convert.ToDateTime(collection["fecha_baja"]);
                Mob.observacion = collection["observacion"];
                Logica.EditarMobiliario(Mob);


                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Mobiliario/Delete/5
        public ActionResult Delete(int id)
        {
            ClassMobiliario Logica = new ClassMobiliario();
            var Info = (List<Mobiliario>)Logica.BuscaMobiliarioPorId(id);
            return View(Info[0]);
        }

        // POST: Mobiliario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ClassMobiliario Logica = new ClassMobiliario();
                Mobiliario Mob = new Mobiliario();
                Mob.MobiliarioId = id;
                Logica.EliminarMobiliario(Mob);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}