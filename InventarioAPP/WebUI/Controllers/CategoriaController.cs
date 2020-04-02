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
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            ClassCategoria Logica = new ClassCategoria();
            var Info = Logica.ListarCategorias();
            return View(Info);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(string name)
        {
            ClassCategoria Logica = new ClassCategoria();
            var Info = (List<Categoria>)Logica.BuscaCategoria(name);
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
                ClassCategoria Logica = new ClassCategoria();
                string respuesta = Logica.NuevaCategoria(collection["nombre_categoria"]);
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
            ClassCategoria Lg = new ClassCategoria();
            var info = (List<Categoria>)Lg.BuscarCategoriaPorId(id);
            return View(info[0]);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                ClassCategoria Logica = new ClassCategoria();
                Categoria CAT = new Categoria();
                CAT.CategoriaId = id;
                string aux = collection["estado_categoria"];
                if (aux != "false")
                {
                    CAT.estado_categoria = true;
                }
                CAT.nombre_categoria = collection["nombre_categoria"];
                CAT.fecha_creacion = Convert.ToDateTime(collection["fecha_creacion"]);
                
                Logica.EditarCategoria(CAT);


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
            ClassCategoria Logica = new ClassCategoria();
            var Info = (List<Categoria>)Logica.BuscarCategoriaPorId(id);
            return View(Info[0]);
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ClassCategoria Logica = new ClassCategoria();
                Categoria CAT = new Categoria();
                CAT.CategoriaId = id;
                Logica.EliminarCategoria(CAT);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("ERROR");
            }
        }
    }
}
