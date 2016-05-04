using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmherstGolfClub.Controllers
{
    public class ProShopController : Controller
    {
        // GET: ProShop
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Pro Shop!";

            return View();
        }
    }
}