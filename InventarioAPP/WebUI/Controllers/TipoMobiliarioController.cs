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
    [Authorize(Roles = "ADMINISTRADOR, DIGITADOR")]
    public class TipoMobiliarioController : Controller
    {
        // GET: TipoMobiliario
        public ActionResult Index()
        {
            ClassTipoMobiliario Logica = new ClassTipoMobiliario();
            var Info = Logica.ListarTipoMobiliario();
            return View(Info);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(string name)
        {
            ClassTipoMobiliario Logica = new ClassTipoMobiliario();
            var Info = (List<Tipomobiliario>)Logica.BuscaTipoMobiliario(name);
            return View(Info[0]);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            ClassCategoria ListaC = new ClassCategoria();
            var InfoC = ListaC.ListarCategorias();
            ViewBag.Categoria = new SelectList(InfoC, "CategoriaId", "nombre_categoria");
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                ClassTipoMobiliario Logica = new ClassTipoMobiliario();
                string respuesta = Logica.NuevoTipoMobiliario(collection["descripcion"], Convert.ToInt32(collection["control_serie"]), Convert.ToInt32(collection["CategoriaId"]));
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
            ClassCategoria ListaC = new ClassCategoria();
            var InfoC = ListaC.ListarCategorias();
            ViewBag.Categoria = new SelectList(InfoC, "CategoriaId", "nombre_categoria");
            ClassTipoMobiliario Lg = new ClassTipoMobiliario();
            var info = (List<Tipomobiliario>)Lg.BuscarTipoMobiliarioPorId(id);
            return View(info[0]);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                ClassTipoMobiliario Logica = new ClassTipoMobiliario();
                Tipomobiliario TiM = new Tipomobiliario();
                TiM.TipomobiliarioId = id;
                string aux = collection["estado_tipomobiliario"];
                if (aux != "false")
                {
                    TiM.estado_tipomobiliario= true;
                }
                TiM.control_serie = Convert.ToInt32(collection["control_serie"]);
                TiM.CategoriaId = Convert.ToInt32(collection["CategoriaId"]);
                TiM.descripcion= collection["descripcion"];

                Logica.EditarTipoMobiliario(TiM);


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
            ClassTipoMobiliario Logica = new ClassTipoMobiliario();
            var Info = (List<Tipomobiliario>)Logica.BuscarTipoMobiliarioPorId(id);
            return View(Info[0]);
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ClassTipoMobiliario Logica = new ClassTipoMobiliario();
                Tipomobiliario TiM= new Tipomobiliario();
                TiM.TipomobiliarioId = id;
                Logica.EliminarTipoMobiliario(TiM);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}