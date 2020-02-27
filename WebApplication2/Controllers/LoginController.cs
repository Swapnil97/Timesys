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


        //public ActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(Member objUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (TrailTimeSysEntities db = new TrailTimeSysEntities())
        //        {
        //            var obj = db.Members.Where(a => a.Name.Equals(objUser.Name) && a.Password.Equals(objUser.Password)).FirstOrDefault();
        //            if (obj != null)
        //            {
        //                Session["UserName"] = obj.Name.ToString();
        //                return RedirectToAction("UserDashBoard");
        //            }
        //        }
        //    }
        //    return View(objUser);
        //}

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