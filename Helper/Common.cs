using Seating.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;

namespace Seating.Helper
{
    public class Common
    {
        //This code return us partial view as html string
        public static string RenderPartialAsString(string viewName, object model, ControllerContext ControllerContext)
        {
            if (string.IsNullOrEmpty(viewName))
                viewName = ControllerContext.RouteData.GetRequiredString("action");
            ViewDataDictionary ViewData = new ViewDataDictionary();
            TempDataDictionary TempData = new TempDataDictionary();
            ViewData.Model = model;

            using (StringWriter sw = new StringWriter())
            {
                ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);

                return sw.GetStringBuilder().ToString();
            }

        }

        public static String RenderRazorViewToString(ControllerContext controllerContext, String viewName)
        {
            using (var sw = new StringWriter())
            {
                var ViewResult = ViewEngines.Engines.FindPartialView(controllerContext, viewName);
                var ViewContext = new ViewContext(controllerContext, ViewResult.View, controllerContext.Controller.ViewData, controllerContext.Controller.TempData, sw);
                ViewResult.View.Render(ViewContext, sw);
                ViewResult.ViewEngine.ReleaseView(controllerContext, ViewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
        public static List<string> getTimes()
        {
            
            


            //you can add as much you want
            List<string> times = new List<string>();
            var dt = DateTime.Now;
            if (dt.Hour >= 02 && dt.Hour < 04)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 2, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 2, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 3, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 3, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 4, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 4, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 8, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 9, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 9, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 04 && dt.Hour < 06)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 4, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 4, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 8, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 9, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 9, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 06 && dt.Hour < 08)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 8, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 9, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 9, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
            }
            if (dt.Hour >= 08 && dt.Hour < 10)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 8, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 9, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 9, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
            }
            if (dt.Hour >= 10 && dt.Hour < 12)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
            }
            if (dt.Hour >= 12 && dt.Hour < 14)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 14 && dt.Hour < 16)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 16 && dt.Hour < 18)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }
            if (dt.Hour >= 18 && dt.Hour < 20)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour == 20 || dt.Hour == 21 || dt.Hour == 22 || dt.Hour == 23)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 00 && dt.Hour < 02)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).ToString("M/d/yy HH:mm"));
            }


            return times;

        }
        public static List<string> getTimesOver()
        {
            List<string> times = new List<string>();
            var dt = DateTime.Now;
            if (dt.Hour >= 00 && dt.Hour < 01)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
            }
            if (dt.Hour >= 01 && dt.Hour < 02)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
            }
            if (dt.Hour >= 02 && dt.Hour < 03)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 03 && dt.Hour < 04)
            {               
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 04 && dt.Hour < 05)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 05 && dt.Hour < 06)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 06 && dt.Hour < 07)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 07 && dt.Hour < 08)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
            }
            if (dt.Hour >= 08 && dt.Hour < 09)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 09 && dt.Hour < 10)
            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
            }
            if (dt.Hour >= 10 && dt.Hour < 11)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 11 && dt.Hour < 12)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 11, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 12 && dt.Hour < 13)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 12, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 13 && dt.Hour < 14)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 14 && dt.Hour < 15)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 14, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 15 && dt.Hour < 16)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 15, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 16 && dt.Hour < 17)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 16, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 17 && dt.Hour < 18)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 17, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 18 && dt.Hour < 19)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 18, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 19 && dt.Hour < 20)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 19, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 20 && dt.Hour < 21)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 20, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 21 && dt.Hour < 22)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 21, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour >= 22 && dt.Hour < 23)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 22, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }

            if (dt.Hour == 20 || dt.Hour == 21 || dt.Hour == 22 || dt.Hour == 23)

            {
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 00, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 23, 30, 0).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 00, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 01, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 02, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 03, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 04, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 05, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 06, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 07, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 08, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 09, 30, 0).AddDays(1).ToString("M/d/yy HH:mm"));
                times.Add(new DateTime(dt.Year, dt.Month, dt.Day, 10, 00, 0).AddDays(1).ToString("M/d/yy HH:mm"));
            }


            return times;

        }
    }
}
