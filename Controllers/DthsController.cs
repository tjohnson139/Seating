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
    public class DthsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Dths
        public ActionResult Index()
        {
            var dths = db.Dths.Include(d => d.Employee);
            return View(dths.ToList());
        }

        // GET: Dths/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dth dth = db.Dths.Find(id);
            if (dth == null)
            {
                return HttpNotFound();
            }
            return View(dth);
        }

        // GET: Dths/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName");
            return View();
        }

        // POST: Dths/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DthID,EmployeeID,TimeEntered,TimeCleared,EmpSent")] Dth dth)
        {
            if (ModelState.IsValid)
            {
                db.Dths.Add(dth);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", dth.EmployeeID);
            return View(dth);
        }

        // GET: Dths/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dth dth = db.Dths.Find(id);
            if (dth == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", dth.EmployeeID);
            return View(dth);
        }

        // POST: Dths/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DthID,EmployeeID,TimeEntered,TimeCleared,EmpSent")] Dth dth)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dth).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", dth.EmployeeID);
            return View(dth);
        }

        // GET: Dths/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dth dth = db.Dths.Find(id);
            if (dth == null)
            {
                return HttpNotFound();
            }
            return View(dth);
        }

        // POST: Dths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dth dth = db.Dths.Find(id);
            db.Dths.Remove(dth);
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
