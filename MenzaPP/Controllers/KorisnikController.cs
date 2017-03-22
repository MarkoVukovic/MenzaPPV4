using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace MenzaPP.Controllers
{
    public class KorisnikController : Controller
    {
        private menzappEntities db = new menzappEntities();
        
        // GET: Korisnik
        public ActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                var userEmail = User.Identity.GetUserName();
                Korisnik korisnik = db.Korisniks.Where(x => x.email == userEmail).First();
                return View(korisnik);
            }
            return View("Error");            
        }
    }
}