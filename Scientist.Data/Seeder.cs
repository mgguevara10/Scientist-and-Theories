using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using Scientist.DataModels;

namespace Scientist.Data.Migrations
{
    public static class Seeder
    {
        public static void Seed(ApplicationDbContext context, bool createTheories = true)
        {
            if (createTheories)
                CreateTheories(context);
        }
        public static void CreateTheories(ApplicationDbContext context)
        {
            context.Theories.AddOrUpdate(
                c => c.Name,
                new Theory { Name = "General Reletivity", Scientist = "Albert Einstein", Details = "Massive objects cause a distortion in space-time, which is felt as gravity" },
                new Theory { Name = "Electromagnetic waves Field Theory", Scientist = "Michael Faraday", Details = "An electric current in a wire produces a magnetic field whose direction depends on the direction of the current" },
                new Theory { Name = "Theory of Radioactivity", Scientist = "Marie Curie", Details = " Techniques for isolating radioactive isotopes, and the discovery of two new elements, radium and polonium" },
                new Theory { Name = "Contribution to Atmoic Theory", Scientist = "Neils Bohr", Details = "postulated based on quantum theory that electrons travel around an atomic nucleus in a stationary orbit" }
                );
            context.SaveChanges();
        }
    }
}
    