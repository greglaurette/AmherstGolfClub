using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmherstGolfClub.Controllers
{
    public class RatesController : Controller
    {
        public ActionResult RatesMain()
        {
            return View();
        }
        public ActionResult GeneralRates()
        {
            return View();
        }
        public ActionResult Membership()
        {
            return View();
        }
        public ActionResult Corp()
        {
            return View();
        }
    }
}