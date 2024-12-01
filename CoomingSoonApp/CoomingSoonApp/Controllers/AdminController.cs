using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoomingSoonApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Emails()
        {
            return View();
        }
        public ActionResult Requests()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Signout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}