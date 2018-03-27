using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HuangLiang.ASP.MVC.Models;

namespace HuangLiang.ASP.MVC.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialView
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult UseAPartialView()
        {
            return View(new EventsAndMenus());

        }

        public ActionResult UseAPartialView3()
        {
            return View();

        }

        public ActionResult ShowEvents()
        {
            ViewBag.EventTitle = "Live Events";
            return View(new EventsAndMenus().Events);
        }
    }
}