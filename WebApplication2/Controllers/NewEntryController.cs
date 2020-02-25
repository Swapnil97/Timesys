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
            ViewBag.MemberList = ToSelectList(_dt1,"Name");
            SqlDataAdapter _da2 = new SqlDataAdapter("select * from Team", constr);
            DataTable _dt2 = new DataTable();
            _da2.Fill(_dt2);
            ViewBag.TeamList = ToSelectList(_dt2,"Name");

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
        public SelectList ToSelectList(DataTable table,string valueField)
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

            return new SelectList(list,"Text","Value");
        }


    } 
}