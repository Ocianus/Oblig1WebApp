﻿using Oblig1WebApp.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Oblig1WebApp.Controllers
{
    public class BestillingController : Controller
    {
        public ActionResult Bestilling()
        {
            return View();
        }

        [HttpPost]
        public ActionResult regBestilling(Bestilling innBestilling)
        {
            var db = new DBContext();
            bool OK = db.lagreBestilling(innBestilling);
            if (OK)
            {
                return RedirectToAction("listBestillinger");
            } else
            {
                return RedirectToAction("Bestilling");
            }
            
        }

        public ActionResult listBestillinger()
        {
            var db = new DBContext();
            List<Bestilling> alleBestillinger = db.alleBestillinger();
            return View(alleBestillinger);
        }

        public ActionResult regAvgang()
        {
            return View();
        }

        [HttpPost]
        public ActionResult regAvgang(Avgang innAvgang)
        {
            var db = new DBContext();
            bool OK = db.lagreAvgang(innAvgang);
            if (OK)
            {
                return RedirectToAction("listAvganger");
            }
            return View();
        }

        public ActionResult listAvganger()
        {
            var db = new DBContext();
            List<Avgang> alleAvganger = db.alleAvganger();
            return View(alleAvganger);
        }

        public ActionResult endreAvgang(int id)
        {
            var db = new DBContext();
            Avgang enAvgang = db.hentAvgang(id);
            return View(enAvgang);
        }

        [HttpPost]
        public ActionResult endreAvgang(Avgang innAvgang)
        {
            var db = new DBContext();
            bool OK = db.endreAvgang(innAvgang);
            if (OK)
            {
                RedirectToAction("listAvganger");
            }
            return View();
        }

        public ActionResult slettAvgang(int id)
        {
            var db = new DBContext();
            bool OK = db.slettAvgang(id);
            if (OK)
            {
                RedirectToAction("listAvganger");
            }
            return View();
        }

        
        public ActionResult registrerAvgangAvgang()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult registrerAvgangAvgang(AvgangAvgang innAvgang)
        {
            var db = new DBContext();
            bool OK = db.lagreAvgangAvgang(innAvgang);
            if (OK)
            {
                return RedirectToAction("listAvganger");
            }
            return View();
        }

        public ActionResult listAvgangerAvganger()
        {
            var db = new DBContext();
            List<AvgangAvgang> alleAvganger = db.alleAvgangerAvganger();
            return View(alleAvganger);
        }
    }
}