using CalendarRoundTwo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CalendarRoundTwo.Database
{
    public class CalendarDb : DbContext
    {
        public CalendarDb()
            : base("DefaultConnection")
        {

        }

        public DbSet<Calendar> Calendar { get; set; }
    }

}