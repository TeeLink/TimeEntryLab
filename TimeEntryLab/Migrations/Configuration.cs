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
                d => d.Name,
                new Developer() {EmailAddress = "tee@linkcorp.com", Name = "Tee Link"},
                new Developer() {EmailAddress = "daniel@linkcorp.com", Name = "Daniel Pollock"},
                new Developer() {EmailAddress = "reid@linkcorp.com", Name = "Reid Hanna"},
                new Developer() {EmailAddress = "magnum@linkcorp.com", Name = "Tony Allen"}
                );

            context.Projects.AddOrUpdate(
                p => p.Name,
                new Project() {Name = "Dept. of Agriculture Database", StartDate = new DateTime(2013, 5, 6)},
                new Project() {Name = "Secretary of State Website", StartDate = new DateTime(2014, 9, 10)},
                new Project() { Name = "Court Records Filing System", StartDate = new DateTime(2010, 05, 04)}
                );

            context.Clients.AddOrUpdate(
                c => c.Name,
                new Client() { Name = "Dept. of Agriculture" },
                new Client() { Name = "Secretary of State" },
                new Client() { Name = "County/Circuit Courthouse"}
                );

            context.Groups.AddOrUpdate(
                g => g.Name,
                new Group() { Name = "Front End" },
                new Group() { Name = "Back End" }
                );



        }
    }
}
