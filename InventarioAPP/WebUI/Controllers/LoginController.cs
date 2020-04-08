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
                ClassTipoUsuario tu = new ClassTipoUsuario();
                Session["Role"] = tu.GetUserRole(HttpContext.User.Identity.Name)[0];
                return Redirect("/Home/index");
            }
            
        }

        [HttpPost] //inicio de sesion
        public ActionResult Login(Usuario user)
        {
            if (IsValid(user))
            {
                FormsAuthentication.SetAuthCookie(user.userName, false);
                ClassTipoUsuario tu = new ClassTipoUsuario();
                Session["Role"] = tu.GetUserRole(user.userName)[0];
                return Redirect("/Home/index");
            }
            else
            {
                return View(user);
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Home/index");
        }

        private bool IsValid(Usuario user)
        {
            ClassUsuario usuario = new ClassUsuario();
            Password pwd = new Password();
            bool IsValid = false;
            IEnumerable busca = usuario.BuscaUsuarioPorUserPWD(user.userName, pwd.Encrypt(user.password));

            if (busca.Cast<object>().Any())
                IsValid = true;

            return IsValid;
        }
    }
}