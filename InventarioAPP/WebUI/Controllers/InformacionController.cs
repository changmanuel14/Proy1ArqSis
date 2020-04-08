using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class InformacionController : Controller
    {
        // GET: Informacion
        [Authorize]
        [Authorize(Roles = "ADMINISTRADOR, GERENTE")]
        public ActionResult Index()
        {
            return View();
        }
    }
}