using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeXrmEasy;
using Chapter03.Plugins.Sample3;
using Common.Entities;
using Chapter02.Repositories;

namespace Chapter03.Plugins.UnitTests
{
    [TestClass]
    public class RepositoryFactoryTests
    {
        [TestMethod]
        public void Execute_CreateOpportunityRepository_ReturnValidObject()
        {
            var context = new XrmFakedContext();
            var orgService = context.GetOrganizationService();

            var factory = new RepositoryFactory(orgService);
            var opportunityRepo = factory.Get<Opportunity, OpportunityRepository>();

            Assert.IsInstanceOfType(opportunityRepo, typeof(OpportunityRepository)); 

        }
    }
}
