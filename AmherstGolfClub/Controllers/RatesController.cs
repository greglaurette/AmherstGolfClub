using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmherstGolfClub.Controllers
{
    public class RatesController : Controller
    {
        // GET: Rates
        public ActionResult RatesMain()
        {
            return View();
        }
        public ActionResult DrivingRange()
        {
            return View();
        }
        public ActionResult GreenFee()
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