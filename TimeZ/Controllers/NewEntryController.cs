using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeZ.Controllers
{
    public class NewEntryController : Controller
    {

        // GET: NewEntry
        private TrailTimeSysEntities db = new TrailTimeSysEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(TimesheetExcel timesheetExcel)
        {
            if(!ModelState.IsValid) //Form is invalid or something return it so it can be fixed
            {
                return View(timesheetExcel);
            }
            db.TimesheetExcels.Add(timesheetExcel);
            db.SaveChanges();
            return Redirect("/NewEntry/Index");
        }
    }
}