using CalendarRoundTwo.Database;
using CalendarRoundTwo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalendarRoundTwo.Controllers
{
    public class CalendarController : Controller
    {
        private CalendarDb db = new CalendarDb();

        // GET: Calendar
        public ActionResult Index(int Year, int Month, int Day)
        {
            var dataForCalendar = db.Calendar.Where(w => w.StartDate.Year == Year & w.StartDate.Month == Month & w.StartDate.Day == Day);
            
            return View(dataForCalendar);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Calendar calendar)
        {
            db.Calendar.Add(calendar);
            db.SaveChanges();

            var day = calendar.StartDate.Day;
            var month = calendar.StartDate.Month;
            var year = calendar.StartDate.Year;
            return Redirect("/Calendar/Index?Year=" + year + "&Month=" + month + "&Day=" + day);


        }


    }
}