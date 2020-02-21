using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstMigration.Models;

namespace CodeFirstMigration.Controllers
{
    public class HomeController : Controller
    {
        UserContext UContext;

        public HomeController()
        {
            UContext = new UserContext();
        }
        public ActionResult Index()
        {
            List<UserInfo> users = new List<UserInfo>();
            users = UContext.UserInfo.ToList();
            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}