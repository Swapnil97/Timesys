using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using WebApplication2;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
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

        [HttpPost]
        public ActionResult Login(Member model)
        {
            TrailTimeSysEntities cbe = new TrailTimeSysEntities();
            var s = cbe.GetMember(model.Name, model.Password);

            var item = s.FirstOrDefault();
            if (item == "Success")
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




                return View("~/Views/NewEntry/AddUser.cshtml");
            }
            else if (item == "User Does not Exists")

            {
                ViewBag.NotValidUser = item;
            }
            else
            {
                ViewBag.Failedcount = item;
            }

            return View("~/Views/Login/Login.cshtml");
        }
        public ActionResult UserDashBoard()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}