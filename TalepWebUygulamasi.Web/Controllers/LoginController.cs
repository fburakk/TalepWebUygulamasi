using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TalepWebUygulamasi.Entities;
using TalepWebUygulamasi.Services;

namespace TalepWebUygulamasi.Web.Controllers
{
    public class LoginController : Controller
    {
        LoginIslemler loginIslemler = new LoginIslemler();

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(HUser user, string ReturnUrl)
        {
            if (loginIslemler.IsValid(user))
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return Redirect(ReturnUrl);
            }
            else
            {
                return View(user);
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Talep/Index");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(HUser user)
        {
            bool isSuccessfullyRegistered = loginIslemler.saveUser(user);
            if (isSuccessfullyRegistered)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return Redirect("/Talep/Index");
            }
            return View();
        }
    }
}