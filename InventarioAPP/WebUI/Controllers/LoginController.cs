using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BusinessLogicLayer;
using Models;

namespace WebUI.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Login
        public ActionResult Login()
        {
            if(!User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return Redirect("/Home");
            }
            
        }

        [HttpPost] //inicio de sesion
        public ActionResult Login(Usuario user)
        {
            if (IsValid(user))
            {
                FormsAuthentication.SetAuthCookie(user.userName, false);
                return Redirect("/Home");
            }
            else
            {
                return View(user);
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Home");
        }

        private bool IsValid(Usuario user)
        {
            ClassUsuario usuario = new ClassUsuario();
            bool IsValid = false;
            IEnumerable busca = usuario.BuscaUsuarioPorUserPWD(user.userName, user.password);

            if (busca.Cast<object>().Any())
                IsValid = true;

            return IsValid;
        }
    }
}