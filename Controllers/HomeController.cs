using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using Seating.Helper;
using Seating.Models;
using System.Threading.Tasks;

namespace Seating.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Employeess
        // Sets up the information for the table on the main page
        public ActionResult Index()
        {

            var breaks = db.Breaks.ToList();
            foreach (var item in breaks)
            {
                Break mdl = new Break();
                mdl.BreakID = item.BreakID;
                mdl.Employee = item.Employee;
                mdl.TimeEntered = item.TimeEntered;
                mdl.TimeCleared = item.TimeCleared;
                mdl.PositionID = item.PositionID;
                mdl.EmpSent = item.EmpSent;
                if (db.Breaks != null)
                {
                    db.Breaks.Add(mdl);
                }
                db.Breaks.Add(mdl);
            }
            var employee = db.Employees.ToList();
            foreach (var item in employee)
            {
                Employee mdl = new Employee();
                mdl.EmployeeID = item.EmployeeID;
                mdl.FirstName = item.FirstName;
                mdl.LastName = item.LastName;
                mdl.NotActive = item.NotActive;
                mdl.Force = item.Force;
                mdl.DisplayName = item.DisplayName;
                if (db.Employees != null)
                {
                    db.Employees.Add(mdl);
                }
            }
            var dthmodel = db.Dths.ToList();
            foreach (var item in dthmodel)
            {
                Dth mdl = new Dth();
                mdl.DthID = item.DthID;
                mdl.Employee = item.Employee;
                mdl.TimeCleared = item.TimeCleared;
                mdl.TimeEntered = item.TimeEntered;
                mdl.PositionID = item.PositionID;
                mdl.EmpSent = item.EmpSent;
                if (db.Dths != null)
                {
                    db.Dths.Add(mdl);
                }
            }

            var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
            foreach (var item in lunchModel)
            {
                Lunch mdl = new Lunch();
                mdl.Employee = item.Employee;
                mdl.LunchID = item.LunchID;
                mdl.PositionID = item.PositionID;
                mdl.LunchTime = item.LunchTime;
                mdl.LongerLunch = item.LongerLunch;
                mdl.Double = item.Double;
                mdl.TimeEntered = item.TimeEntered;
                mdl.EmpSent = item.EmpSent;
                mdl.TimeCleared = item.TimeCleared;
                if (db.Lunches != null)
                {
                    db.Lunches.Add(mdl);
                }
            }
            var positionModel = db.Positions.ToList();
            foreach (var item in positionModel)
            {
                Position mdl = new Position();
                mdl.PositionID = item.PositionID;
                mdl.PositionName = item.PositionName;
                if (db.Positions != null)
                {
                    db.Positions.Add(mdl);
                }
            }

            ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
            ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
            ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
            ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
            ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
            ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
            ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
            ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
            ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();


            return View();
        }

        public JsonResult GetDropDownsPartial()
        {
            var breaks = db.Breaks.ToList();
            foreach (var item in breaks)
            {
                Break mdl = new Break();
                mdl.BreakID = item.BreakID;
                mdl.Employee = item.Employee;
                mdl.TimeEntered = item.TimeEntered;
                mdl.TimeCleared = item.TimeCleared;
                mdl.PositionID = item.PositionID;
                mdl.EmpSent = item.EmpSent;
                if (db.Breaks != null)
                {
                    db.Breaks.Add(mdl);
                }
                db.Breaks.Add(mdl);
            }
            var employee = db.Employees.ToList();
            foreach (var item in employee)
            {
                Employee mdl = new Employee();
                mdl.EmployeeID = item.EmployeeID;
                mdl.FirstName = item.FirstName;
                mdl.LastName = item.LastName;
                mdl.NotActive = item.NotActive;
                mdl.Force = item.Force;
                mdl.DisplayName = item.DisplayName;
                if (db.Employees != null)
                {
                    db.Employees.Add(mdl);
                }
            }
            var dthmodel = db.Dths.ToList();
            foreach (var item in dthmodel)
            {
                Dth mdl = new Dth();
                mdl.DthID = item.DthID;
                mdl.Employee = item.Employee;
                mdl.TimeCleared = item.TimeCleared;
                mdl.TimeEntered = item.TimeEntered;
                mdl.PositionID = item.PositionID;
                mdl.EmpSent = item.EmpSent;
                if (db.Dths != null)
                {
                    db.Dths.Add(mdl);
                }
            }

            var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
            foreach (var item in lunchModel)
            {
                Lunch mdl = new Lunch();
                mdl.Employee = item.Employee;
                mdl.LunchID = item.LunchID;
                mdl.PositionID = item.PositionID;
                mdl.LunchTime = item.LunchTime;
                mdl.LongerLunch = item.LongerLunch;
                mdl.Double = item.Double;
                mdl.TimeEntered = item.TimeEntered;
                mdl.EmpSent = item.EmpSent;
                mdl.TimeCleared = item.TimeCleared;
                if (db.Lunches != null)
                {
                    db.Lunches.Add(mdl);
                }
            }
            var positionModel = db.Positions.ToList();
            foreach (var item in positionModel)
            {
                Position mdl = new Position();
                mdl.PositionID = item.PositionID;
                mdl.PositionName = item.PositionName;
                if (db.Positions != null)
                {
                    db.Positions.Add(mdl);
                }
            }

            ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
            ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
            ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
            ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
            ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
            ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
            ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
            ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
            ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

            string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
            return Json(new { valid = true, html = partialHtml }, JsonRequestBehavior.AllowGet);

        }


        [System.Web.Http.HttpPost]
        public ActionResult CreateData(Break breaks)
        {
            try
            {
                breaks.TimeEntered = DateTime.Now;
                db.Breaks.Add(breaks);
                db.SaveChanges();

                var breaksList = db.Breaks.ToList();
                foreach (var item in breaksList)
                {
                    Break mdl = new Break();
                    mdl.BreakID = item.BreakID;
                    mdl.Employee = item.Employee;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Breaks != null)
                    {
                        db.Breaks.Add(mdl);
                    }
                    db.Breaks.Add(mdl);
                }
                var employee = db.Employees.ToList();
                foreach (var item in employee)
                {
                    Employee mdl = new Employee();
                    mdl.EmployeeID = item.EmployeeID;
                    mdl.FirstName = item.FirstName;
                    mdl.LastName = item.LastName;
                    mdl.NotActive = item.NotActive;
                    mdl.Force = item.Force;
                    mdl.DisplayName = item.DisplayName;
                    if (db.Employees != null)
                    {
                        db.Employees.Add(mdl);
                    }
                }
                var dthmodel = db.Dths.ToList();
                foreach (var item in dthmodel)
                {
                    Dth mdl = new Dth();
                    mdl.DthID = item.DthID;
                    mdl.Employee = item.Employee;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Dths != null)
                    {
                        db.Dths.Add(mdl);
                    }
                }

                var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
                foreach (var item in lunchModel)
                {
                    Lunch mdl = new Lunch();
                    mdl.Employee = item.Employee;
                    mdl.LunchID = item.LunchID;
                    mdl.PositionID = item.PositionID;
                    mdl.LunchTime = item.LunchTime;
                    mdl.LongerLunch = item.LongerLunch;
                    mdl.Double = item.Double;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.EmpSent = item.EmpSent;
                    mdl.TimeCleared = item.TimeCleared;
                    if (db.Lunches != null)
                    {
                        db.Lunches.Add(mdl);
                    }
                }
                var positionModel = db.Positions.ToList();
                foreach (var item in positionModel)
                {
                    Position mdl = new Position();
                    mdl.PositionID = item.PositionID;
                    mdl.PositionName = item.PositionName;
                    if (db.Positions != null)
                    {
                        db.Positions.Add(mdl);
                    }
                }

                ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
                ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
                ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

                string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
                return Json(new { success = true, html = partialHtml }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult DeleteBreaks(int breakID)
        {
            try
            {
                var oldBreaksModel = db.Breaks.Where(x => x.BreakID == breakID).FirstOrDefault();
                oldBreaksModel.TimeCleared = DateTime.Now;
                db.SaveChanges();

                var breaksList = db.Breaks.ToList();
                foreach (var item in breaksList)
                {
                    Break mdl = new Break();
                    mdl.BreakID = item.BreakID;
                    mdl.Employee = item.Employee;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Breaks != null)
                    {
                        db.Breaks.Add(mdl);
                    }
                    db.Breaks.Add(mdl);
                }
                var employee = db.Employees.ToList();
                foreach (var item in employee)
                {
                    Employee mdl = new Employee();
                    mdl.EmployeeID = item.EmployeeID;
                    mdl.FirstName = item.FirstName;
                    mdl.LastName = item.LastName;
                    mdl.NotActive = item.NotActive;
                    mdl.Force = item.Force;
                    mdl.DisplayName = item.DisplayName;
                    if (db.Employees != null)
                    {
                        db.Employees.Add(mdl);
                    }
                }
                var dthmodel = db.Dths.ToList();
                foreach (var item in dthmodel)
                {
                    Dth mdl = new Dth();
                    mdl.DthID = item.DthID;
                    mdl.Employee = item.Employee;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Dths != null)
                    {
                        db.Dths.Add(mdl);
                    }
                }

                var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
                foreach (var item in lunchModel)
                {
                    Lunch mdl = new Lunch();
                    mdl.Employee = item.Employee;
                    mdl.LunchID = item.LunchID;
                    mdl.PositionID = item.PositionID;
                    mdl.LunchTime = item.LunchTime;
                    mdl.LongerLunch = item.LongerLunch;
                    mdl.Double = item.Double;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.EmpSent = item.EmpSent;
                    mdl.TimeCleared = item.TimeCleared;
                    if (db.Lunches != null)
                    {
                        db.Lunches.Add(mdl);
                    }
                }
                var positionModel = db.Positions.ToList();
                foreach (var item in positionModel)
                {
                    Position mdl = new Position();
                    mdl.PositionID = item.PositionID;
                    mdl.PositionName = item.PositionName;
                    if (db.Positions != null)
                    {
                        db.Positions.Add(mdl);
                    }
                }

                ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
                ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
                ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

                string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
                return Json(new { success = true, html = partialHtml }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult empSentBreaks(int breakID)
        {
            try
            {
                var oldBreaksModel = db.Breaks.Where(x => x.BreakID == breakID).FirstOrDefault();
                oldBreaksModel.EmpSent = true;
                db.SaveChanges();

                var breaksList = db.Breaks.ToList();
                foreach (var item in breaksList)
                {
                    Break mdl = new Break();
                    mdl.BreakID = item.BreakID;
                    mdl.Employee = item.Employee;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Breaks != null)
                    {
                        db.Breaks.Add(mdl);
                    }
                    db.Breaks.Add(mdl);
                }
                var employee = db.Employees.ToList();
                foreach (var item in employee)
                {
                    Employee mdl = new Employee();
                    mdl.EmployeeID = item.EmployeeID;
                    mdl.FirstName = item.FirstName;
                    mdl.LastName = item.LastName;
                    mdl.NotActive = item.NotActive;
                    mdl.Force = item.Force;
                    mdl.DisplayName = item.DisplayName;
                    if (db.Employees != null)
                    {
                        db.Employees.Add(mdl);
                    }
                }
                var dthmodel = db.Dths.ToList();
                foreach (var item in dthmodel)
                {
                    Dth mdl = new Dth();
                    mdl.DthID = item.DthID;
                    mdl.Employee = item.Employee;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Dths != null)
                    {
                        db.Dths.Add(mdl);
                    }
                }

                var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
                foreach (var item in lunchModel)
                {
                    Lunch mdl = new Lunch();
                    mdl.Employee = item.Employee;
                    mdl.LunchID = item.LunchID;
                    mdl.PositionID = item.PositionID;
                    mdl.LunchTime = item.LunchTime;
                    mdl.LongerLunch = item.LongerLunch;
                    mdl.Double = item.Double;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.EmpSent = item.EmpSent;
                    mdl.TimeCleared = item.TimeCleared;
                    if (db.Lunches != null)
                    {
                        db.Lunches.Add(mdl);
                    }
                }
                var positionModel = db.Positions.ToList();
                foreach (var item in positionModel)
                {
                    Position mdl = new Position();
                    mdl.PositionID = item.PositionID;
                    mdl.PositionName = item.PositionName;
                    if (db.Positions != null)
                    {
                        db.Positions.Add(mdl);
                    }
                }

                ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
                ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
                ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

                string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
                return Json(new { success = true, html = partialHtml }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult empSentDth(int dthID)
        {
            try
            {
                var oldDthModel = db.Dths.Where(x => x.DthID == dthID).FirstOrDefault();
                oldDthModel.EmpSent = true;
                db.SaveChanges();

                var breaksList = db.Breaks.ToList();
                foreach (var item in breaksList)
                {
                    Break mdl = new Break();
                    mdl.BreakID = item.BreakID;
                    mdl.Employee = item.Employee;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Breaks != null)
                    {
                        db.Breaks.Add(mdl);
                    }
                    db.Breaks.Add(mdl);
                }
                var employee = db.Employees.ToList();
                foreach (var item in employee)
                {
                    Employee mdl = new Employee();
                    mdl.EmployeeID = item.EmployeeID;
                    mdl.FirstName = item.FirstName;
                    mdl.LastName = item.LastName;
                    mdl.NotActive = item.NotActive;
                    mdl.Force = item.Force;
                    mdl.DisplayName = item.DisplayName;
                    if (db.Employees != null)
                    {
                        db.Employees.Add(mdl);
                    }
                }
                var dthmodel = db.Dths.ToList();
                foreach (var item in dthmodel)
                {
                    Dth mdl = new Dth();
                    mdl.DthID = item.DthID;
                    mdl.Employee = item.Employee;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Dths != null)
                    {
                        db.Dths.Add(mdl);
                    }
                }

                var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
                foreach (var item in lunchModel)
                {
                    Lunch mdl = new Lunch();
                    mdl.Employee = item.Employee;
                    mdl.LunchID = item.LunchID;
                    mdl.PositionID = item.PositionID;
                    mdl.LunchTime = item.LunchTime;
                    mdl.LongerLunch = item.LongerLunch;
                    mdl.Double = item.Double;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.EmpSent = item.EmpSent;
                    mdl.TimeCleared = item.TimeCleared;
                    if (db.Lunches != null)
                    {
                        db.Lunches.Add(mdl);
                    }
                }
                var positionModel = db.Positions.ToList();
                foreach (var item in positionModel)
                {
                    Position mdl = new Position();
                    mdl.PositionID = item.PositionID;
                    mdl.PositionName = item.PositionName;
                    if (db.Positions != null)
                    {
                        db.Positions.Add(mdl);
                    }
                }

                ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
                ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
                ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

                string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
                return Json(new { success = true, html = partialHtml }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult empSentCxl(int breakID)
        {
            try
            {
                var oldBreakModel = db.Breaks.Where(x => x.BreakID == breakID).FirstOrDefault();
                oldBreakModel.EmpSent = false;
                db.SaveChanges();

                var breaksList = db.Breaks.ToList();
                foreach (var item in breaksList)
                {
                    Break mdl = new Break();
                    mdl.BreakID = item.BreakID;
                    mdl.Employee = item.Employee;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Breaks != null)
                    {
                        db.Breaks.Add(mdl);
                    }
                    db.Breaks.Add(mdl);
                }
                var employee = db.Employees.ToList();
                foreach (var item in employee)
                {
                    Employee mdl = new Employee();
                    mdl.EmployeeID = item.EmployeeID;
                    mdl.FirstName = item.FirstName;
                    mdl.LastName = item.LastName;
                    mdl.NotActive = item.NotActive;
                    mdl.Force = item.Force;
                    mdl.DisplayName = item.DisplayName;
                    if (db.Employees != null)
                    {
                        db.Employees.Add(mdl);
                    }
                }
                var dthmodel = db.Dths.ToList();
                foreach (var item in dthmodel)
                {
                    Dth mdl = new Dth();
                    mdl.DthID = item.DthID;
                    mdl.Employee = item.Employee;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Dths != null)
                    {
                        db.Dths.Add(mdl);
                    }
                }

                var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
                foreach (var item in lunchModel)
                {
                    Lunch mdl = new Lunch();
                    mdl.Employee = item.Employee;
                    mdl.LunchID = item.LunchID;
                    mdl.PositionID = item.PositionID;
                    mdl.LunchTime = item.LunchTime;
                    mdl.LongerLunch = item.LongerLunch;
                    mdl.Double = item.Double;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.EmpSent = item.EmpSent;
                    mdl.TimeCleared = item.TimeCleared;
                    if (db.Lunches != null)
                    {
                        db.Lunches.Add(mdl);
                    }
                }
                var positionModel = db.Positions.ToList();
                foreach (var item in positionModel)
                {
                    Position mdl = new Position();
                    mdl.PositionID = item.PositionID;
                    mdl.PositionName = item.PositionName;
                    if (db.Positions != null)
                    {
                        db.Positions.Add(mdl);
                    }
                }

                ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
                ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
                ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

                string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
                return Json(new { success = true, html = partialHtml }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }

        public ActionResult dthSentCxl(int dthID)
        {
            try
            {
                var oldDthModel = db.Dths.Where(x => x.DthID == dthID).FirstOrDefault();
                oldDthModel.EmpSent = false;
                db.SaveChanges();

                var breaksList = db.Breaks.ToList();
                foreach (var item in breaksList)
                {
                    Break mdl = new Break();
                    mdl.BreakID = item.BreakID;
                    mdl.Employee = item.Employee;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Breaks != null)
                    {
                        db.Breaks.Add(mdl);
                    }
                    db.Breaks.Add(mdl);
                }
                var employee = db.Employees.ToList();
                foreach (var item in employee)
                {
                    Employee mdl = new Employee();
                    mdl.EmployeeID = item.EmployeeID;
                    mdl.FirstName = item.FirstName;
                    mdl.LastName = item.LastName;
                    mdl.NotActive = item.NotActive;
                    mdl.Force = item.Force;
                    mdl.DisplayName = item.DisplayName;
                    if (db.Employees != null)
                    {
                        db.Employees.Add(mdl);
                    }
                }
                var dthmodel = db.Dths.ToList();
                foreach (var item in dthmodel)
                {
                    Dth mdl = new Dth();
                    mdl.DthID = item.DthID;
                    mdl.Employee = item.Employee;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Dths != null)
                    {
                        db.Dths.Add(mdl);
                    }
                }

                var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
                foreach (var item in lunchModel)
                {
                    Lunch mdl = new Lunch();
                    mdl.Employee = item.Employee;
                    mdl.LunchID = item.LunchID;
                    mdl.PositionID = item.PositionID;
                    mdl.LunchTime = item.LunchTime;
                    mdl.LongerLunch = item.LongerLunch;
                    mdl.Double = item.Double;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.EmpSent = item.EmpSent;
                    mdl.TimeCleared = item.TimeCleared;
                    if (db.Lunches != null)
                    {
                        db.Lunches.Add(mdl);
                    }
                }
                var positionModel = db.Positions.ToList();
                foreach (var item in positionModel)
                {
                    Position mdl = new Position();
                    mdl.PositionID = item.PositionID;
                    mdl.PositionName = item.PositionName;
                    if (db.Positions != null)
                    {
                        db.Positions.Add(mdl);
                    }
                }

                ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
                ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
                ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

                string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
                return Json(new { success = true, html = partialHtml }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }

        public ActionResult lunchSentCxl(int lunchID)
        {
            try
            {
                var oldlunchModel = db.Lunches.Where(x => x.LunchID == lunchID).FirstOrDefault();
                oldlunchModel.EmpSent = false;
                db.SaveChanges();

                var breaksList = db.Breaks.ToList();
                foreach (var item in breaksList)
                {
                    Break mdl = new Break();
                    mdl.BreakID = item.BreakID;
                    mdl.Employee = item.Employee;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Breaks != null)
                    {
                        db.Breaks.Add(mdl);
                    }
                    db.Breaks.Add(mdl);
                }
                var employee = db.Employees.ToList();
                foreach (var item in employee)
                {
                    Employee mdl = new Employee();
                    mdl.EmployeeID = item.EmployeeID;
                    mdl.FirstName = item.FirstName;
                    mdl.LastName = item.LastName;
                    mdl.NotActive = item.NotActive;
                    mdl.Force = item.Force;
                    mdl.DisplayName = item.DisplayName;
                    if (db.Employees != null)
                    {
                        db.Employees.Add(mdl);
                    }
                }
                var dthmodel = db.Dths.ToList();
                foreach (var item in dthmodel)
                {
                    Dth mdl = new Dth();
                    mdl.DthID = item.DthID;
                    mdl.Employee = item.Employee;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Dths != null)
                    {
                        db.Dths.Add(mdl);
                    }
                }

                var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
                foreach (var item in lunchModel)
                {
                    Lunch mdl = new Lunch();
                    mdl.Employee = item.Employee;
                    mdl.LunchID = item.LunchID;
                    mdl.PositionID = item.PositionID;
                    mdl.LunchTime = item.LunchTime;
                    mdl.LongerLunch = item.LongerLunch;
                    mdl.Double = item.Double;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.EmpSent = item.EmpSent;
                    mdl.TimeCleared = item.TimeCleared;
                    if (db.Lunches != null)
                    {
                        db.Lunches.Add(mdl);
                    }
                }
                var positionModel = db.Positions.ToList();
                foreach (var item in positionModel)
                {
                    Position mdl = new Position();
                    mdl.PositionID = item.PositionID;
                    mdl.PositionName = item.PositionName;
                    if (db.Positions != null)
                    {
                        db.Positions.Add(mdl);
                    }
                }

                ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
                ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
                ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

                string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
                return Json(new { success = true, html = partialHtml }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult empSentLunch(int lunchID)
        {
            try
            {
                var oldBreaksModel = db.Lunches.Where(x => x.LunchID == lunchID).FirstOrDefault();
                oldBreaksModel.EmpSent = true;
                db.SaveChanges();

                var breaksList = db.Breaks.ToList();
                foreach (var item in breaksList)
                {
                    Break mdl = new Break();
                    mdl.BreakID = item.BreakID;
                    mdl.Employee = item.Employee;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Breaks != null)
                    {
                        db.Breaks.Add(mdl);
                    }
                    db.Breaks.Add(mdl);
                }
                var employee = db.Employees.ToList();
                foreach (var item in employee)
                {
                    Employee mdl = new Employee();
                    mdl.EmployeeID = item.EmployeeID;
                    mdl.FirstName = item.FirstName;
                    mdl.LastName = item.LastName;
                    mdl.NotActive = item.NotActive;
                    mdl.Force = item.Force;
                    mdl.DisplayName = item.DisplayName;
                    if (db.Employees != null)
                    {
                        db.Employees.Add(mdl);
                    }
                }
                var dthmodel = db.Dths.ToList();
                foreach (var item in dthmodel)
                {
                    Dth mdl = new Dth();
                    mdl.DthID = item.DthID;
                    mdl.Employee = item.Employee;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Dths != null)
                    {
                        db.Dths.Add(mdl);
                    }
                }

                var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
                foreach (var item in lunchModel)
                {
                    Lunch mdl = new Lunch();
                    mdl.Employee = item.Employee;
                    mdl.LunchID = item.LunchID;
                    mdl.PositionID = item.PositionID;
                    mdl.LunchTime = item.LunchTime;
                    mdl.LongerLunch = item.LongerLunch;
                    mdl.Double = item.Double;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.EmpSent = item.EmpSent;
                    mdl.TimeCleared = item.TimeCleared;
                    if (db.Lunches != null)
                    {
                        db.Lunches.Add(mdl);
                    }
                }
                var positionModel = db.Positions.ToList();
                foreach (var item in positionModel)
                {
                    Position mdl = new Position();
                    mdl.PositionID = item.PositionID;
                    mdl.PositionName = item.PositionName;
                    if (db.Positions != null)
                    {
                        db.Positions.Add(mdl);
                    }
                }

                ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
                ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
                ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

                string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
                return Json(new { success = true, html = partialHtml }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }

        [System.Web.Http.HttpPost]
        public ActionResult CreateDth(Dth dths)
        {
            try
            {
                dths.TimeEntered = DateTime.Now;
                db.Dths.Add(dths);
                db.SaveChanges();

                var breaksList = db.Breaks.ToList();
                foreach (var item in breaksList)
                {
                    Break mdl = new Break();
                    mdl.BreakID = item.BreakID;
                    mdl.Employee = item.Employee;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Breaks != null)
                    {
                        db.Breaks.Add(mdl);
                    }
                    db.Breaks.Add(mdl);
                }
                var employee = db.Employees.ToList();
                foreach (var item in employee)
                {
                    Employee mdl = new Employee();
                    mdl.EmployeeID = item.EmployeeID;
                    mdl.FirstName = item.FirstName;
                    mdl.LastName = item.LastName;
                    mdl.NotActive = item.NotActive;
                    mdl.Force = item.Force;
                    mdl.DisplayName = item.DisplayName;
                    if (db.Employees != null)
                    {
                        db.Employees.Add(mdl);
                    }
                }
                var dthmodel = db.Dths.ToList();
                foreach (var item in dthmodel)
                {
                    Dth mdl = new Dth();
                    mdl.DthID = item.DthID;
                    mdl.Employee = item.Employee;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Dths != null)
                    {
                        db.Dths.Add(mdl);
                    }
                }

                var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
                foreach (var item in lunchModel)
                {
                    Lunch mdl = new Lunch();
                    mdl.Employee = item.Employee;
                    mdl.LunchID = item.LunchID;
                    mdl.PositionID = item.PositionID;
                    mdl.LunchTime = item.LunchTime;
                    mdl.LongerLunch = item.LongerLunch;
                    mdl.Double = item.Double;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.EmpSent = item.EmpSent;
                    mdl.TimeCleared = item.TimeCleared;
                    if (db.Lunches != null)
                    {
                        db.Lunches.Add(mdl);
                    }
                }
                var positionModel = db.Positions.ToList();
                foreach (var item in positionModel)
                {
                    Position mdl = new Position();
                    mdl.PositionID = item.PositionID;
                    mdl.PositionName = item.PositionName;
                    if (db.Positions != null)
                    {
                        db.Positions.Add(mdl);
                    }
                }

                ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
                ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
                ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

                string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
                return Json(new { success = true, html = partialHtml }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }

        public ActionResult CheckDb(int id)
        {
            var checkDbTimes = db.Lunches.Find(id);

            return View(checkDbTimes);
        }

        [HttpPost]
        public ActionResult DeleteDth(int dthID)
        {
            try
            {
                var oldDthModel = db.Dths.Where(x => x.DthID == dthID).FirstOrDefault();
                oldDthModel.TimeCleared = DateTime.Now;
                db.SaveChanges();

                var breaksList = db.Breaks.ToList();
                foreach (var item in breaksList)
                {
                    Break mdl = new Break();
                    mdl.BreakID = item.BreakID;
                    mdl.Employee = item.Employee;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Breaks != null)
                    {
                        db.Breaks.Add(mdl);
                    }
                    db.Breaks.Add(mdl);
                }
                var employee = db.Employees.ToList();
                foreach (var item in employee)
                {
                    Employee mdl = new Employee();
                    mdl.EmployeeID = item.EmployeeID;
                    mdl.FirstName = item.FirstName;
                    mdl.LastName = item.LastName;
                    mdl.NotActive = item.NotActive;
                    mdl.Force = item.Force;
                    mdl.DisplayName = item.DisplayName;
                    if (db.Employees != null)
                    {
                        db.Employees.Add(mdl);
                    }
                }
                var dthmodel = db.Dths.ToList();
                foreach (var item in dthmodel)
                {
                    Dth mdl = new Dth();
                    mdl.DthID = item.DthID;
                    mdl.Employee = item.Employee;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Dths != null)
                    {
                        db.Dths.Add(mdl);
                    }
                }

                var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
                foreach (var item in lunchModel)
                {
                    Lunch mdl = new Lunch();
                    mdl.Employee = item.Employee;
                    mdl.LunchID = item.LunchID;
                    mdl.PositionID = item.PositionID;
                    mdl.LunchTime = item.LunchTime;
                    mdl.LongerLunch = item.LongerLunch;
                    mdl.Double = item.Double;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    if (db.Lunches != null)
                    {
                        db.Lunches.Add(mdl);
                    }
                }
                var positionModel = db.Positions.ToList();
                foreach (var item in positionModel)
                {
                    Position mdl = new Position();
                    mdl.PositionID = item.PositionID;
                    mdl.PositionName = item.PositionName;
                    if (db.Positions != null)
                    {
                        db.Positions.Add(mdl);
                    }
                }

                ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
                ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
                ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

                string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
                return Json(new { success = true, html = partialHtml }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }

        [System.Web.Http.HttpPost]
        public ActionResult CreateLunch(Lunch lunch)
        {
            try
            {
                lunch.TimeEntered = DateTime.Now;
                db.Lunches.Add(lunch);
                db.SaveChanges();

                var breaksList = db.Breaks.ToList();
                foreach (var item in breaksList)
                {
                    Break mdl = new Break();
                    mdl.BreakID = item.BreakID;
                    mdl.Employee = item.Employee;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Breaks != null)
                    {
                        db.Breaks.Add(mdl);
                    }
                    db.Breaks.Add(mdl);
                }
                var employee = db.Employees.ToList();
                foreach (var item in employee)
                {
                    Employee mdl = new Employee();
                    mdl.EmployeeID = item.EmployeeID;
                    mdl.FirstName = item.FirstName;
                    mdl.LastName = item.LastName;
                    mdl.NotActive = item.NotActive;
                    mdl.Force = item.Force;
                    mdl.DisplayName = item.DisplayName;
                    if (db.Employees != null)
                    {
                        db.Employees.Add(mdl);
                    }
                }
                var dthmodel = db.Dths.ToList();
                foreach (var item in dthmodel)
                {
                    Dth mdl = new Dth();
                    mdl.DthID = item.DthID;
                    mdl.Employee = item.Employee;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Dths != null)
                    {
                        db.Dths.Add(mdl);
                    }
                }

                var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
                foreach (var item in lunchModel)
                {
                    Lunch mdl = new Lunch();
                    mdl.Employee = item.Employee;
                    mdl.LunchID = item.LunchID;
                    mdl.PositionID = item.PositionID;
                    mdl.LunchTime = item.LunchTime;
                    mdl.LongerLunch = item.LongerLunch;
                    mdl.Double = item.Double;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.EmpSent = item.EmpSent;
                    mdl.TimeCleared = item.TimeCleared;
                    if (db.Lunches != null)
                    {
                        db.Lunches.Add(mdl);
                    }
                }
                var positionModel = db.Positions.ToList();
                foreach (var item in positionModel)
                {
                    Position mdl = new Position();
                    mdl.PositionID = item.PositionID;
                    mdl.PositionName = item.PositionName;
                    if (db.Positions != null)
                    {
                        db.Positions.Add(mdl);
                    }
                }

                ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
                ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
                ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

                string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
                return Json(new { success = true, html = partialHtml }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public ActionResult DeleteLunch(int lunchID)
        {
            try
            {
                var oldLunchModel = db.Lunches.Where(x => x.LunchID == lunchID).FirstOrDefault();
                oldLunchModel.TimeCleared = DateTime.Now;
                db.SaveChanges();

                var breaksList = db.Breaks.ToList();
                foreach (var item in breaksList)
                {
                    Break mdl = new Break();
                    mdl.BreakID = item.BreakID;
                    mdl.Employee = item.Employee;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Breaks != null)
                    {
                        db.Breaks.Add(mdl);
                    }
                    db.Breaks.Add(mdl);
                }
                var employee = db.Employees.ToList();
                foreach (var item in employee)
                {
                    Employee mdl = new Employee();
                    mdl.EmployeeID = item.EmployeeID;
                    mdl.FirstName = item.FirstName;
                    mdl.LastName = item.LastName;
                    mdl.NotActive = item.NotActive;
                    mdl.Force = item.Force;
                    mdl.DisplayName = item.DisplayName;
                    if (db.Employees != null)
                    {
                        db.Employees.Add(mdl);
                    }
                }
                var dthmodel = db.Dths.ToList();
                foreach (var item in dthmodel)
                {
                    Dth mdl = new Dth();
                    mdl.DthID = item.DthID;
                    mdl.Employee = item.Employee;
                    mdl.TimeCleared = item.TimeCleared;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.PositionID = item.PositionID;
                    mdl.EmpSent = item.EmpSent;
                    if (db.Dths != null)
                    {
                        db.Dths.Add(mdl);
                    }
                }

                var lunchModel = db.Lunches.OrderBy(x => x.LunchTime);
                foreach (var item in lunchModel)
                {
                    Lunch mdl = new Lunch();
                    mdl.Employee = item.Employee;
                    mdl.LunchID = item.LunchID;
                    mdl.PositionID = item.PositionID;
                    mdl.LunchTime = item.LunchTime;
                    mdl.LongerLunch = item.LongerLunch;
                    mdl.Double = item.Double;
                    mdl.TimeEntered = item.TimeEntered;
                    mdl.EmpSent = item.EmpSent;
                    mdl.TimeCleared = item.TimeCleared;
                    if (db.Lunches != null)
                    {
                        db.Lunches.Add(mdl);
                    }
                }
                var positionModel = db.Positions.ToList();
                foreach (var item in positionModel)
                {
                    Position mdl = new Position();
                    mdl.PositionID = item.PositionID;
                    mdl.PositionName = item.PositionName;
                    if (db.Positions != null)
                    {
                        db.Positions.Add(mdl);
                    }
                }

                ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
                ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
                ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
                ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
                ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
                ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();

                string partialHtml = Common.RenderRazorViewToString(ControllerContext, "~/Views/Home/_DropDowns.cshtml");
                return Json(new { success = true, html = partialHtml }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }



        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Admin()
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
        public ActionResult Register()
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

        public ActionResult Edit()
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

        public ActionResult Delete()
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


        // Returns the no authorization page
        public ActionResult NotAuthorized()
        {
            return View("NotAuthorized");
        }

        public ActionResult LunchNoRedirect()
        {
            return View("LunchNoRedirect");
        }

        public ActionResult Lunch()
        {
            var breaks = db.Breaks.ToList();
            foreach (var item in breaks)
            {
                Break mdl = new Break();
                mdl.BreakID = item.BreakID;
                mdl.Employee = item.Employee;
                mdl.TimeEntered = item.TimeEntered;
                mdl.TimeCleared = item.TimeCleared;
                mdl.PositionID = item.PositionID;
                if (db.Breaks != null)
                {
                    db.Breaks.Add(mdl);
                }
                db.Breaks.Add(mdl);
            }
            var employee = db.Employees.ToList();
            foreach (var item in employee)
            {
                Employee mdl = new Employee();
                mdl.EmployeeID = item.EmployeeID;
                mdl.FirstName = item.FirstName;
                mdl.LastName = item.LastName;
                mdl.NotActive = item.NotActive;
                mdl.Force = item.Force;
                mdl.DisplayName = item.DisplayName;
                if (db.Employees != null)
                {
                    db.Employees.Add(mdl);
                }
            }
            var dthmodel = db.Dths.ToList();
            foreach (var item in dthmodel)
            {
                Dth mdl = new Dth();
                mdl.DthID = item.DthID;
                mdl.Employee = item.Employee;
                mdl.TimeCleared = item.TimeCleared;
                mdl.TimeEntered = item.TimeEntered;
                mdl.PositionID = item.PositionID;
                if (db.Dths != null)
                {
                    db.Dths.Add(mdl);
                }
            }

            var lunchModel = db.Lunches.ToList();
            foreach (var item in lunchModel)
            {
                Lunch mdl = new Lunch();
                mdl.Employee = item.Employee;
                mdl.LunchID = item.LunchID;
                mdl.PositionID = item.PositionID;
                mdl.LunchTime = item.LunchTime;
                mdl.LongerLunch = item.LongerLunch;
                mdl.Double = item.Double;
                mdl.TimeEntered = item.TimeEntered;
                mdl.TimeCleared = item.TimeCleared;
                if (db.Lunches != null)
                {
                    db.Lunches.Add(mdl);
                }
            }
            var positionModel = db.Positions.ToList();
            foreach (var item in positionModel)
            {
                Position mdl = new Position();
                mdl.PositionID = item.PositionID;
                mdl.PositionName = item.PositionName;
                if (db.Positions != null)
                {
                    db.Positions.Add(mdl);
                }
            }

            ViewBag.EmployeesNames = db.Employees.Where(x => x.NotActive == false).OrderBy(x => x.DisplayName).ToList();
            ViewBag.PositionNames = db.Positions.OrderBy(x => x.PositionName).ToList();
            ViewBag.LunchTimes = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
            ViewBag.Dths = db.Dths.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
            ViewBag.Breaks = db.Breaks.Where(x => x.TimeCleared == null).OrderBy(x => x.TimeEntered).ToList();
            ViewBag.Lunches = db.Lunches.Where(x => x.TimeCleared == null).OrderBy(x => x.LunchTime).ToList();
            ViewBag.breakOffFloor = db.Breaks.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
            ViewBag.dthOffFloor = db.Dths.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
            ViewBag.lunchOffFloor = db.Lunches.Where(x => x.EmpSent == true && x.TimeCleared == null).ToList();
            return View(db);
        }

        public ActionResult brkTableJS()
        {
            var dt = DateTime.Now.AddMinutes(1);
            var breaks = db.Breaks.ToList();
            foreach (var item in breaks)
            {
                Break mdl = new Break();
                mdl.BreakID = item.BreakID;
                mdl.Employee = item.Employee;
                mdl.TimeEntered = item.TimeEntered;
                mdl.TimeCleared = item.TimeCleared;
                mdl.PositionID = item.PositionID;
                if (db.Breaks != null)
                {
                    if (mdl.TimeEntered <= dt)
                    {
                        breaks.Add(mdl);
                    }
                }
            }
            return View(breaks);
        }


        //get dropdown of lunchtime by employee
        public JsonResult GetLunchTimeeDDLByEmployee(int empID)
        {


            var lunchTimeDDL = getunchTimesDDLByEmployee(empID);
            return Json(new { lunchTimeDDL = lunchTimeDDL }, JsonRequestBehavior.AllowGet);
        }

        private string getunchTimesDDLByEmployee(int empID, int? selectedVal = null)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            //checking if selectedvalue is not empty then set dropdown seleted value
            string selected = "";
            if (selectedVal != null)
            {
                selected = "";
            }
            else
            {
                selected = "selected";
            }
            string lunchTimeDDL = "<option value='' " + selected + ">-- Lunch Time --</option>";
            var lunchTimes = context.Lunches.ToList();
            List<string> times = Helper.Common.getTimes();
            //if (lunchTimes.Count > 0)
            //{
            foreach (var time in times)
            {
                bool match = false;
                foreach (var lunchTime in lunchTimes)
                {

                    if (lunchTime.LunchTime.ToShortDateString() == DateTime.Now.ToShortDateString() && lunchTime.LunchTime.ToShortTimeString() == time ||
                        lunchTime.LunchTime.ToString("M/d/yy HH:mm") == time && lunchTime.TimeCleared == null)
                    {
                        match = true;
                    }
                }

                if (!match)
                {
                    lunchTimeDDL += "<option value='" + time + "'  " + selected + ">" + time + "</option>";
                }
            }
            // }
            return lunchTimeDDL;
        }
    }
}