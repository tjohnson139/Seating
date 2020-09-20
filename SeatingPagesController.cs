using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Seating.Models;

namespace Seating
{
    public class SeatingPagesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SeatingPages
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var seatingModel = db.SeatingPage.ToList();
                foreach (var item in seatingModel)
                {
                    SeatingPage mdl = new SeatingPage();
                    mdl.SeatingId = item.SeatingId;
                    mdl.SeatingDate = item.SeatingDate;
                    mdl.URL = item.URL;
                    if (db.SeatingPage != null)
                    {
                        db.SeatingPage.Add(mdl);
                    }
                }
                return View(db.SeatingPage.OrderByDescending(m => m.SeatingDate).ToList());
            }
            else
            {
                return View("NotAuthorized");
            }
        }

        // GET: SeatingPages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SeatingPage seatingPage = db.SeatingPage.Find(id);
            if (seatingPage == null)
            {
                return HttpNotFound();
            }
            return View(seatingPage);
        }

        // GET: SeatingPages/Create
        public ActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return View("NotAuthorized");
            }

        }

        // POST: SeatingPages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SeatingId,SeatingDate,URL")] SeatingPage seatingPage)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (ModelState.IsValid)
                {
                    db.SeatingPage.Add(seatingPage);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                ViewBag.dateList = db.SeatingPage.Where(x => x.SeatingDate >= DateTime.Now).OrderBy(x => x.SeatingDate).ToList();

                return View(seatingPage);
            }
            else
            {
                return View("NotAuthorized");
            }

        }

        // GET: SeatingPages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SeatingPage seatingPage = db.SeatingPage.Find(id);
            if (seatingPage == null)
            {
                return HttpNotFound();
            }
            return View(seatingPage);
        }

        // POST: SeatingPages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SeatingId,SeatingDate,URL")] SeatingPage seatingPage)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (ModelState.IsValid)
                {
                    db.Entry(seatingPage).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(seatingPage);
            }
            else
            {
                return View("NotAuthorized");
            }

        }

        // GET: SeatingPages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SeatingPage seatingPage = db.SeatingPage.Find(id);
            if (seatingPage == null)
            {
                return HttpNotFound();
            }
            return View(seatingPage);
        }

        // POST: SeatingPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SeatingPage seatingPage = db.SeatingPage.Find(id);
            db.SeatingPage.Remove(seatingPage);
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
