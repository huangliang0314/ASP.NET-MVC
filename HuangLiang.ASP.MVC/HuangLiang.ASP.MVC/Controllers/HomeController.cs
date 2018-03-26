using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HuangLiang.ASP.MVC.Models;

namespace HuangLiang.ASP.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //public string Hello()
        //{
        //    return "Hello The World";
        //}

        public string Hello(string id)
        {
            return "Hello The World"+"  "+ id;
        }

        public ActionResult JsonDemo()
        {

            //JSon
            //var m = new Menu()
            //{
            //    Id = 1,
            //    Price = 3.5,
            //    Text = "grilled saulted",
            //    Catogary="Main"
            //};
            //return Json(m, JsonRequestBehavior.AllowGet);

            //重定向
            return RedirectToRoute(new { controller = "Home", action = "Hello" });

        }
    }
}