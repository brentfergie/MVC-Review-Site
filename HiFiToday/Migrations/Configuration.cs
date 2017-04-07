namespace HiFiToday.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HiFiToday.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<HiFiToday.Models.HiFiTodayContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HiFiToday.Models.HiFiTodayContext context)
        {
            context.Categories.AddOrUpdate(x => x.Name,
        new Category() { ID = 1, Name = "Power Amp" },
        new Category() { ID = 2, Name = "Pre Amp" },
        new Category() { ID = 3, Name = "Integrated Amp" }
        );
            context.Reviews.AddOrUpdate(x => x.ID,
        new Review()
        {
            ID = 1,
            Manufacturer = "Line Magnetic",
            Model = "211IA",
            CategoryID = 3,
            Description ="Sounds great"
        },
        new Review()
        {
            ID = 2,
            Manufacturer = "Line Magnetic",
            Model = "216IA",
            CategoryID = 3,
            Description = "Smooth"
        },
        new Review()
        {
            ID = 3,
            Manufacturer = "Line Magnetic",
            Model = "1126",
            CategoryID = 2,
            Description = "A winner of a sound"
        },
        new Review()
        {
            ID = 4,
            Manufacturer = "Line Magnetic",
            Model = "AM2",
            CategoryID = 1,
            Description = "My favorite"
        },
        new Review()
        {
            ID = 5,
            Manufacturer = "Line Magnetic",
            Model = "805",
            CategoryID = 1,
            Description = "I'll own this someday"
        }
        );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
