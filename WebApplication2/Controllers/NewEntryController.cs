using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2.Controllers
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
            string constr = ConfigurationManager.ConnectionStrings["Constring"].ToString();
            SqlConnection _con = new SqlConnection(constr);
            SqlDataAdapter _da1 = new SqlDataAdapter("select * from Member", constr);
            DataTable _dt1 = new DataTable();
            _da1.Fill(_dt1);
            ViewBag.MemberList = ToSelectList(_dt1, "Name");

            SqlDataAdapter _da2 = new SqlDataAdapter("select * from Team", constr);
            DataTable _dt2 = new DataTable();
            _da2.Fill(_dt2);
            ViewBag.TeamList = ToSelectList(_dt2, "Name");

            //Shifts

            SqlDataAdapter _da3 = new SqlDataAdapter("select * from Shift", constr);
            DataTable _dt3 = new DataTable();
            _da3.Fill(_dt3);
            ViewBag.ShiftList = ToSelectList(_dt3, "Name");

            //Applications

            SqlDataAdapter _da4 = new SqlDataAdapter("select * from [Application]", constr);
            DataTable _dt4 = new DataTable();
            _da4.Fill(_dt4);
            ViewBag.AppicationList = ToSelectList(_dt4, "Name");

            //Tasks

            SqlDataAdapter _da5 = new SqlDataAdapter("select * from Task", constr);
            DataTable _dt5 = new DataTable();
            _da5.Fill(_dt5);
            ViewBag.TaskList = ToSelectList(_dt5, "Name");

            //Applications

            SqlDataAdapter _da6 = new SqlDataAdapter("select * from Activity", constr);
            DataTable _dt6 = new DataTable();
            _da6.Fill(_dt6);
            ViewBag.ActivityList = ToSelectList(_dt6, "Name");

            //Priority

            SqlDataAdapter _da7 = new SqlDataAdapter("select * from Priority_Severity", constr);
            DataTable _dt7 = new DataTable();
            _da7.Fill(_dt7);
            ViewBag.PriorityList = ToSelectList(_dt7, "Name");
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(TimesheetExcel timesheetExcel)
        {
            if (!ModelState.IsValid)
            {
                return View(timesheetExcel);
            }
            db.TimesheetExcels.Add(timesheetExcel);
            db.SaveChanges();
            return Redirect("/NewEntry/Index");
        }


        [NonAction]
        public SelectList ToSelectList(DataTable table, string valueField)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (DataRow row in table.Rows)
            {
                list.Add(new SelectListItem()
                {
                    Text = "Select",
                    Value = row[valueField].ToString()
                });
            }

            return new SelectList(list, "Text", "Value");
        }


    } 
}