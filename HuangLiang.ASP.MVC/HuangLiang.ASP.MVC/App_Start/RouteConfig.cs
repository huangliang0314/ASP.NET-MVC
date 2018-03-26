using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HuangLiang.ASP.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{str}",
                defaults: new { controller = "Home", action = "Index", str = UrlParameter.Optional }
            );

            //修改路由1
            routes.MapRoute(
               name: "Default1",
               url: "{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            //修改路由2
            routes.MapRoute(
               name: "Language",
               url: "{language}/{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            //修改路由2 添加约束
            routes.MapRoute(
               name: "Language1",
               url: "{language}/{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               constraints:new { language = @"(en)|(de)" }
               
           );
        }
    }
}
