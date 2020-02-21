using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeZ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string month = "Oct",int year = 2019)
        {
            List<DisplayMonthlyTrends_Result1> DisplayMonthlyTrends_Results = new List<DisplayMonthlyTrends_Result1>();
            using (var context = new TrailTimeSysEntities())
            {
                DisplayMonthlyTrends_Results = context.DisplayMonthlyTrends(month,year).ToList();
            }

            return View(DisplayMonthlyTrends_Results);
        }
    }
}