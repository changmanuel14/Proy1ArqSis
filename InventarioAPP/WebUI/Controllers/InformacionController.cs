using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;

namespace WebUI.Controllers
{
    public class InformacionController : Controller
    {
        // GET: Informacion
        [Authorize]
        [Authorize(Roles = "ADMINISTRADOR, GERENTE")]
        public ActionResult Index()
        {
            ClassEdificio Logica = new ClassEdificio();
            var Info = Logica.informacion1();
            return View(Info);
        }
    }
}