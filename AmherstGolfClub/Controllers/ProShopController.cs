using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AmherstGolfClub.DAL;
using AmherstGolfClub.Models;

namespace AmherstGolfClub.Controllers
{
    public class ProShopController : Controller
    {
        private GolfContext db = new GolfContext();

        // GET: ProShop
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: ProShop/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
