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
    public class ChartDatesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ChartDates
        public ActionResult Index()
        {
            return View(db.ChartDates.ToList());
        }

        // GET: ChartDates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChartDate chartDate = db.ChartDates.Find(id);
            if (chartDate == null)
            {
                return HttpNotFound();
            }
            return View(chartDate);
        }

        // GET: ChartDates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChartDates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ChartID,URLDate,ChartURL")] ChartDate chartDate)
        {
            if (ModelState.IsValid)
            {
                if (db.ChartDates.Any(x => x.URLDate.Equals(chartDate))) 
                {
                    return RedirectToAction("CreateError");
                }
                else
                {
                    db.ChartDates.Add(chartDate);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(chartDate);
        }

        // GET: ChartDates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChartDate chartDate = db.ChartDates.Find(id);
            if (chartDate == null)
            {
                return HttpNotFound();
            }
            return View(chartDate);
        }

        // POST: ChartDates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ChartID,URLDate,ChartURL")] ChartDate chartDate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chartDate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chartDate);
        }

        // GET: ChartDates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChartDate chartDate = db.ChartDates.Find(id);
            if (chartDate == null)
            {
                return HttpNotFound();
            }
            return View(chartDate);
        }

        // POST: ChartDates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChartDate chartDate = db.ChartDates.Find(id);
            db.ChartDates.Remove(chartDate);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateError()
        {
            return View();
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
