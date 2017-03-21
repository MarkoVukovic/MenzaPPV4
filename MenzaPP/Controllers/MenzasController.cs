using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MenzaPP;

namespace MenzaPP.Controllers
{
    public class MenzasController : Controller
    {
        private menzappEntities db = new menzappEntities();

        // GET: Menzas
        public ActionResult Index()
        {
            return View(db.Menzas.ToList());
        }

        // GET: Menzas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menza menza = db.Menzas.Find(id);
            if (menza == null)
            {
                return HttpNotFound();
            }
            return View(menza);
        }

        // GET: Menzas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Menzas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,naziv,adresa")] Menza menza)
        {
            if (ModelState.IsValid)
            {
                db.Menzas.Add(menza);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menza);
        }

        // GET: Menzas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menza menza = db.Menzas.Find(id);
            if (menza == null)
            {
                return HttpNotFound();
            }
            return View(menza);
        }

        // POST: Menzas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,naziv,adresa")] Menza menza)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menza).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menza);
        }

        // GET: Menzas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menza menza = db.Menzas.Find(id);
            if (menza == null)
            {
                return HttpNotFound();
            }
            return View(menza);
        }

        // POST: Menzas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Menza menza = db.Menzas.Find(id);
            db.Menzas.Remove(menza);
            db.SaveChanges();
            return RedirectToAction("Index");
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
