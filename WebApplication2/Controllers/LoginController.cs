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

        [HttpPost]
        public ActionResult Login(Member model)
        {
            TrailTimeSysEntities cbe = new TrailTimeSysEntities();
            var s = cbe.GetMember(model.Name, model.Password);

            var item = s.FirstOrDefault();
            if (item == "Success")
            {

                return View("AddUser");
            }
            else if (item == "User Does not Exists")

            {
                ViewBag.NotValidUser = item;

            }
            else
            {
                ViewBag.Failedcount = item;
            }

            return View("Index");
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