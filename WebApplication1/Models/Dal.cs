using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class Dal : IDal
    {
        private MetierDBContext bdd;

        public Dal()
        {
            bdd = new MetierDBContext();
        }

        public List<Metier> ObtientTousLesMetiers()
        {
            return bdd.Metiers.ToList();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public void CreerMetier(string title)
        {
            bdd.Metiers.Add(new Metier { Title = title });
            bdd.SaveChanges();
        }

        public void ModifierMetier(int id, string title)
        {
            Metier metiersTrouve = bdd.Metiers.FirstOrDefault(metier => metier.ID == id);
            if (metiersTrouve != null)
            {
                metiersTrouve.Title = title;
                bdd.SaveChanges();
            }
        }
    }
}