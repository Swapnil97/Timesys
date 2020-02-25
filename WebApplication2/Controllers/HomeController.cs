using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index(string month = "Oct", int year = 2019)
        {
            List<DisplayMonthlyTrends_Result> DisplayMonthlyTrends_Results = new List<DisplayMonthlyTrends_Result>();
            using (var context = new TrailTimeSysEntities())
            {
                DisplayMonthlyTrends_Results = context.DisplayMonthlyTrends(month, year).ToList();
            }

            return View(DisplayMonthlyTrends_Results);
        }
    }
}