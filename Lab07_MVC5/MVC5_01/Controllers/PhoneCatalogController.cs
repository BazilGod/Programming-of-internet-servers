using MVC5_01.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_01.Controllers
{
    public class PhoneCatalogController : Controller
    {
        PhoneCatalogContext db = new PhoneCatalogContext();
        // GET: PhoneCatalog
        public ActionResult Index()
        {
            return View("Index", db.PhoneCatalogs);
        }

        public ActionResult Add()
        {
            PhoneCatalog phone = new PhoneCatalog();
            return View("Add", phone);
        }

        [HttpPost]
        public ActionResult Add(PhoneCatalog phone)
        {
            if (phone.BDay < DateTime.Now.AddYears(-120))
            {
                ModelState.AddModelError("BDay", "Не ври, тебе не более 120 лет ");
            }
            if (ModelState.IsValid)
            {
                
                db.PhoneCatalogs.Add(phone);
                db.SaveChanges();
                return View("Index", db.PhoneCatalogs);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Update(int? id)
        {
            PhoneCatalog phone = db.PhoneCatalogs.Find(id);
            return View("Update", phone);
        }

        [HttpPost]
        public ActionResult Update(PhoneCatalog phone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phone).State = EntityState.Modified;
                db.SaveChanges();
                return (View("Index", db.PhoneCatalogs));
            }
            else
            {
                ViewBag.ErrorTxt = "Update: error";
                return View("Index", db.PhoneCatalogs);
            }
        }


  public ActionResult Delete(int? id) {
            PhoneCatalog phone = db.PhoneCatalogs.Find(id);
            return View("Delete", phone);
        }

        [HttpPost]
        public ActionResult Delete(PhoneCatalog phone) {
            phone = db.PhoneCatalogs.Find(phone.Id);
            if (phone != null && ModelState.IsValid) {
                db.PhoneCatalogs.Remove(phone);
                db.SaveChanges();
                return View("Index", db.PhoneCatalogs);
            } else {
                ViewBag.ErrorTxt = "Delete: error";
                return View("Index", db.PhoneCatalogs);
            }
        }
    }
}