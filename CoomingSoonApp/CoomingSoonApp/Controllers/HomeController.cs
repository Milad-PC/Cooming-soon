using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoomingSoonApp.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _db = new MyContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmailReq([Bind(Include = "email")]string email)
        {
            EmailReq src = new EmailReq();
            src.ReqDate = DateTime.Now;
            src.EmailAddress = email;

            _db.EmailRequests.Add(src);
            _db.SaveChanges();

            return RedirectToAction("Thanks");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TextReq([Bind(Include = "Name,Message,Email")]Request src)
        {
            src.RequestDate = DateTime.Now;
            _db.Requests.Add(src);
            _db.SaveChanges();

            return RedirectToAction("Thanks");
        }
        public ActionResult Thanks()
        {
            return View();
        }
        public ActionResult Timer()
        {
            return PartialView();
        }
    }
}