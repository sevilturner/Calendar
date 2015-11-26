namespace CalendarRoundTwo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CalendarRoundTwo.Database.CalendarDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CalendarRoundTwo.Database.CalendarDb context)
        {

        }
    }
}
