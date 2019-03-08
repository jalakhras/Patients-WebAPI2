namespace WebApi2.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApi2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApi2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApi2.Models.ApplicationDbContext context)
        {

            if (!context.Patients.Any(p => p.Name == "Scott"))
            {
                var data = new List<Patient>()
                {
                    new Patient { Name = "Scott",
                                  Ailments = new List<Ailment>() { new Ailment { Name="Crazy" }, new Ailment { Name="Old" }},
                                  Medications = new List<Medication> { new Medication { Name="Aspirin", Doses = 2}}
                    },
                    new Patient { Name = "Joy",
                                  Ailments = new List<Ailment>() { new Ailment { Name="Crazy" }, new Ailment { Name="Young" }},
                                  Medications = new List<Medication> { new Medication { Name="Aspirin", Doses = 2}}
                    },
                    new Patient { Name = "Sarah",
                                  Ailments = new List<Ailment>() { new Ailment { Name="Crazy" }, new Ailment { Name="Youngest" }},
                                  Medications = new List<Medication> { new Medication { Name="Aspirin", Doses = 2}}
                    }
                };
                foreach (var p in data)
                {
                    context.Patients.AddOrUpdate(p);
                    context.SaveChanges();
                }

            }

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
