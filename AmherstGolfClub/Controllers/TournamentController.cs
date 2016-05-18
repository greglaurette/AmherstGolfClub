using AmherstGolfClub.Models;
using AmherstGolfClub.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AmherstGolfClub.Controllers
{
    public class TournamentController : Controller
    {
        GolfContext db = new GolfContext();
        // GET: Tournament
        public ActionResult Index()
        {
            return View(db.Tournaments.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tournament tourny = db.Tournaments.Find(id);
            if (tourny == null)
            {
                return HttpNotFound();
            }
            return View(tourny);
        }

    }
}