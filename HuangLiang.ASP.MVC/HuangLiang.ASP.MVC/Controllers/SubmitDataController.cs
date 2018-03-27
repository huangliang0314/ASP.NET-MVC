using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HuangLiang.ASP.MVC.Models;

namespace HuangLiang.ASP.MVC.Controllers
{
    public class SubmitDataController : Controller
    {
        // GET: SubmitData
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreatMenu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatMenu(int id,string text,double price,string category)
        {
            var menu = new Menu() { Id=id,Text=text,Price=price,Category=category};
            ViewBag.Info = string.Format("menu created: {0}, Price:{1}, category:{2}", menu.Text, menu.Price, menu.Category);
            return View("Index");
        }

        [HttpPost]
        public ActionResult CreatMenu(Menu menu)
        {
            ViewBag.Info = string.Format("menu created: {0}, Price:{1}, category:{2}",menu.Text,menu.Price,menu.Category);
            return View("Index");
        }
    }
}