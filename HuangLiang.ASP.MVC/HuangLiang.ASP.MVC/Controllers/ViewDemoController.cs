using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HuangLiang.ASP.MVC.Models;

namespace HuangLiang.ASP.MVC.Controllers
{
    public class ViewDemoController : Controller
    {
        // GET: ViewDemo
        public ActionResult Index()
        {
            ViewBag.MyData = "This is from huangliang";
            return View();
        }

        public ActionResult PassingAModel()
        {

            List<Menu> menus = new List<Menu>()
            {
                new Menu()
                {
                    Id = 1,
                    Price = 3.5,
                    Text = "grilled saulted",
                    Category="Main"
                },
                 new Menu()
                {
                    Id = 2,
                    Price = 4.5,
                    Text = "grilled saulted",
                    Category="Main"
                },
                  new Menu()
                {
                    Id = 3,
                    Price = 5.5,
                    Text = "grilled saulted",
                    Category="Main"
                },
                   new Menu()
                {
                    Id = 4,
                    Price = 6.5,
                    Text = "grilled saulted",
                    Category="Main"
                },
        };
            return View(menus);

        }


        public ActionResult LayoutSample()
        {

            return View();
        }
    }
}