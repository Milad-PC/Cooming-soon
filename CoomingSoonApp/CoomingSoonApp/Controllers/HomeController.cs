﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoomingSoonApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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