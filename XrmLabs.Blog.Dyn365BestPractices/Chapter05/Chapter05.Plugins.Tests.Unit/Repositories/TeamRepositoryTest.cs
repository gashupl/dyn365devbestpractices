using System;
using System.Collections.Generic;
using System.Reflection;
using Chapter05.Plugins.Repositories;
using Common.Entities;
using FakeXrmEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Moq;

namespace Chapter05.Plugins.Tests.Unit.Repositories
{
    [TestClass]
    public class TeamRepositoryTest : RepositoryTestBase
    {
        [TestMethod]
        public void GetSalesTeam_TeamExists_ReturnTeam()
        {
            var context = new XrmFakedContext();
            context.ProxyTypesAssembly = Assembly.GetAssembly(typeof(Team));
            var team1 = new Team() { Id = Guid.NewGuid(), Name = "My super sales team" };
            var team2 = new Team() { Id = Guid.NewGuid(), Name = "Another not so super team" };

            context.Initialize(new List<Entity>() {
                team1, team2
            });

            var teamRepository = new TeamRepository();
            teamRepository.Initialize(GetServiceFactoryMockedObject(context), Guid.NewGuid()); 

            var salesTeam = teamRepository.GetSalesTeam();
            Assert.IsNotNull(salesTeam); 
        }

        [TestMethod]
        public void GetSalesTeam_TeamDoesNotExist_ReturnNull()
        {
            var context = new XrmFakedContext();
            context.ProxyTypesAssembly = Assembly.GetAssembly(typeof(Team));
            var team1 = new Team() { Id = Guid.NewGuid(), Name = "My super sales team not existing anymore" };
            var team2 = new Team() { Id = Guid.NewGuid(), Name = "Another not so super team" };

            context.Initialize(new List<Entity>() {
                team1, team2
            });

            var teamRepository = new TeamRepository();
            teamRepository.Initialize(GetServiceFactoryMockedObject(context), Guid.NewGuid());

            var salesTeam = teamRepository.GetSalesTeam();
            Assert.IsNull(salesTeam);
        }

    }
}
