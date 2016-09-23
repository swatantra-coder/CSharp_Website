using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Tests
{
    [TestClass]
    public class DalTests
    {
        [TestInitialize]
        public void Init_AvantChaqueTest()
        {
            IDatabaseInitializer<MetierDBContext> init = new DropCreateDatabaseAlways<MetierDBContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new MetierDBContext());
        }

        [TestMethod]
        public void CreerMetier_AvecUnNouveauMetier_ObtientTousLesMetiersRenvoitBienLeMetier()
        {
            using (IDal dal = new Dal())
            {
                dal.CreerMetier("Développeur");
                List<Metier> metiers = dal.ObtientTousLesMetiers();

                Assert.IsNotNull(metiers);
                Assert.AreEqual(1, metiers.Count);
                Assert.AreEqual("Développeur", metiers[0].Title);
            }
        }

        [TestMethod]
        public void ModifierMetier_CreationDUnNouveauMetierEtChangementTitle_LaModificationEstCorrecteApresRechargement()
        {
            using (IDal dal = new Dal())
            {
                dal.CreerMetier("Developpeur");
                List<Metier> metiers = dal.ObtientTousLesMetiers();
                int id = metiers.First(r => r.Title == "Developpeur").ID;

                dal.ModifierMetier(id, "Développeur");

                metiers = dal.ObtientTousLesMetiers();
                Assert.IsNotNull(metiers);
                Assert.AreEqual(1, metiers.Count);
                Assert.AreEqual("Développeur", metiers[0].Title);
            }
        }
    }
}
