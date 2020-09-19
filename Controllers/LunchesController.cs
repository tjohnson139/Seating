using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Seating.Models;

namespace Seating.Controllers
{
    public class LunchesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Lunches
        public ActionResult Index()
        {
            var lunches = db.Lunches.Include(l => l.Employee).Include(l => l.Position);
            return View(lunches.ToList());
        }

        // GET: Lunches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lunch lunch = db.Lunches.Find(id);
            if (lunch == null)
            {
                return HttpNotFound();
            }
            return View(lunch);
        }

        // GET: Lunches/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName");
            ViewBag.PositionID = new SelectList(db.Positions, "PositionID", "PositionName");
            return View();
        }

        // POST: Lunches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LunchID,EmployeeID,LunchTime,PositionID,TimeEntered,TimeCleared,EmpSent")] Lunch lunch)
        {
            if (ModelState.IsValid)
            {
                db.Lunches.Add(lunch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", lunch.EmployeeID);
            ViewBag.PositionID = new SelectList(db.Positions, "PositionID", "PositionName", lunch.PositionID);
            return View(lunch);
        }

        // GET: Lunches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lunch lunch = db.Lunches.Find(id);
            if (lunch == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", lunch.EmployeeID);
            ViewBag.PositionID = new SelectList(db.Positions, "PositionID", "PositionName", lunch.PositionID);
            return View(lunch);
        }

        // POST: Lunches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LunchID,EmployeeID,LunchTime,PositionID,TimeCleared,EmpSent")] Lunch lunch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lunch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", lunch.EmployeeID);
            ViewBag.PositionID = new SelectList(db.Positions, "PositionID", "PositionName", lunch.PositionID);
            return View(lunch);
        }

        // GET: Lunches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lunch lunch = db.Lunches.Find(id);
            if (lunch == null)
            {
                return HttpNotFound();
            }
            return View(lunch);
        }

        // POST: Lunches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lunch lunch = db.Lunches.Find(id);
            db.Lunches.Remove(lunch);
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
