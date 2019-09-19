using System;
using Chapter04.Plugins.Repositories;
using Chapter04.Plugins.Services;
using Common.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimpleInjector;

namespace Chapter04.Plugin.Tests
{
    [TestClass]
    public class OpportunityTestServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repo = new Mock<IOpportunityRepository>();
            repo.Setup(r => r.Create(It.IsAny<Opportunity>())); 

            Container container = new Container();
            container.Register<IRepository<Opportunity>>(() => repo.Object);

            RepositoryFactory factory = new RepositoryFactory(container); 
            var testService = new OpportunityTestService(factory);
            testService.DoSomething(new Opportunity()); 

        }
    }
}
