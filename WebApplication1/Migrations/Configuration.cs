namespace WebApplication1.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.MetierDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.MetierDBContext context)
        {
            var metiers = new List<Metier>
            {
                new Metier { Title = "Développeur" },
                new Metier { Title = "Chef de projet" },
                new Metier { Title = "Designer" },
                new Metier { Title = "Directeur" }
            };

            metiers.ForEach(m => context.Metiers.AddOrUpdate(p => p.Title, m));
            context.SaveChanges();
        }
    }
}
