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
    public class BreaksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Breaks
        public ActionResult Index()
        {
            var breaks = db.Breaks.Include(d => d.Employee);
            return View(breaks.ToList());
        }

        // GET: Breaks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Break @break = db.Breaks.Find(id);
            if (@break == null)
            {
                return HttpNotFound();
            }
            return View(@break);
        }

        // GET: Breaks/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName");
            return View();
        }

        // POST: Breaks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BreakID,EmployeeID,TimeEntered,TimeCleared,EmpSent")] Break @break)
        {
            if (ModelState.IsValid)
            {
                db.Breaks.Add(@break);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", @break.EmployeeID);
            return View(@break);
        }

        // GET: Breaks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Break @break = db.Breaks.Find(id);
            if (@break == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", @break.EmployeeID);
            return View(@break);
        }

        // POST: Breaks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BreakID,EmployeeID,TimeEntered,TimeCleared,EmpSent")] Break @break)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@break).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", @break.EmployeeID);
            return View(@break);
        }

        // GET: Breaks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Break @break = db.Breaks.Find(id);
            if (@break == null)
            {
                return HttpNotFound();
            }
            return View(@break);
        }

        // POST: Breaks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Break @break = db.Breaks.Find(id);
            db.Breaks.Remove(@break);
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
