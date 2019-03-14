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


        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(HUser user, string ReturnUrl)
        {
            LoginIslemler loginIslemler = new LoginIslemler();
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
    }
}