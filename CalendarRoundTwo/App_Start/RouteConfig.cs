using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CalendarRoundTwo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var day = DateTime.Now.Day;
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{Year}/{Month}/{Day}",
                defaults: new { controller = "Calendar", action = "Index", Year = year, Month = month, Day = day}
            );
        }
    }
}
