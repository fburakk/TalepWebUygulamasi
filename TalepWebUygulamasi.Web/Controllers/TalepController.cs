using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TalepWebUygulamasi.Entities;
using TalepWebUygulamasi.Services;

namespace TalepWebUygulamasi.Web.Controllers
{            
    [Authorize]
    public class TalepController : Controller
    {
        TalepIslemler talepIslemler = new TalepIslemler();
        KullaniciIslemler kullaniciIslemler = new KullaniciIslemler();


        // GET: Talep
        public ActionResult Index()
        {
            var talepler = talepIslemler.TalepleriGetir();
            ViewData["uname"] = User.Identity.Name;
            ViewData["urole"] = kullaniciIslemler.KullaniciyiGetir(User.Identity.Name).Role;
            return View(talepler);
        }

        // GET: Talep/Details/5
        public ActionResult Details(int id)
        {
            var talep = talepIslemler.TalebiGetir(id);
            ViewData["uname"] = User.Identity.Name;
            ViewData["urole"] = kullaniciIslemler.KullaniciyiGetir(User.Identity.Name).Role;
            return View(talep);
        }

        // GET: Talep/Create
        public ActionResult Create()
        {
            ViewData["uname"] = User.Identity.Name;
            ViewData["urole"] = kullaniciIslemler.KullaniciyiGetir(User.Identity.Name).Role;
            return View();
        }

        // POST: Talep/Create
        [HttpPost]
        public ActionResult Create(Talep talep)
        {
            try
            {
                // TODO: Add insert logic here
                talepIslemler.TalepEkle(talep);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Talep/Edit/5
        public ActionResult Edit(int id)
        {
            var talep = talepIslemler.TalebiGetir(id);
            ViewData["uname"] = User.Identity.Name;
            ViewData["urole"] = kullaniciIslemler.KullaniciyiGetir(User.Identity.Name).Role;
            return View(talep);
        }

        // POST: Talep/Edit/5
        [HttpPost]
        public ActionResult Edit(Talep talep)
        {
            try
            {
                // TODO: Add update logic here
                talepIslemler.TalepGuncelle(talep);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Talep/Delete/5
        public ActionResult Delete(int id)
        {
            var silinecekTalep = talepIslemler.TalebiGetir(id);
            ViewData["uname"] = User.Identity.Name;
            ViewData["urole"] = kullaniciIslemler.KullaniciyiGetir(User.Identity.Name).Role;
            return View(silinecekTalep);
        }

        // POST: Talep/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Talep talep)
        {
            try
            {
                // TODO: Add delete logic here
                talepIslemler.TalepSil(id);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                //Console.WriteLine(ex.Message);
                return View(talep);
            }
        }

        // GET: Talep/Evaluate/5
        public ActionResult Evaluate(int id)
        {
            var talep = talepIslemler.TalebiGetir(id);
            ViewData["uname"] = User.Identity.Name;
            ViewData["urole"] = kullaniciIslemler.KullaniciyiGetir(User.Identity.Name).Role;
            return View(talep);
        }

        // POST: Talep/Edit/5
        [HttpPost]
        public ActionResult Evaluate(Talep talep)
        {
            try
            {
                // TODO: Add update logic here
                talepIslemler.TalepGuncelle(talep);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
