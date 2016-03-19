namespace TimeEntryLab.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TimeEntryLab.TimeEntryDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "TimeEntryLab.TimeEntryDBContext";
        }

        protected override void Seed(TimeEntryLab.TimeEntryDBContext context)
        {
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

            context.Developers.AddOrUpdate(
                d=> d.Name,
                new Developer() { EmailAddress =  "tee@link.com", Name = "Tee Link"},
                new Developer() { EmailAddress =  "daniel@link.com", Name = "Daniel Pollock"}
                );

            context.Projects.AddOrUpdate(
                  p => p.Name,
                  new Project() { Name = "Dept. of Agriculture Database", StartDate = new DateTime(2013, 5, 6)},
                  new Project() { Name = "Secretary of State Website", StartDate = new DateTime(2014, 9, 10)}              
                  );

            context.Clients.AddOrUpdate(
                  p => p.Name,
                  new Client() { Name = "Dept. of Agriculture" },
                  new Client() { Name = "Secretary of State"}
                  );


        }
    } 
}
