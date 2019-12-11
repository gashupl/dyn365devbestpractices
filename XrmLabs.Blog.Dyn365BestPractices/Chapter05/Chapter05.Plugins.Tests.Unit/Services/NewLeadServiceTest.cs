using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter05.Plugins.Repositories;
using Chapter05.Plugins.Repositories.Common;
using Chapter05.Plugins.Services;
using Common.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Moq;

namespace Chapter05.Plugins.Tests.Unit.Services
{
    [TestClass]
    public class NewLeadServiceTest
    {
        //Task repository mock
        private class TaskRepositoryMock : ITaskRepository
        {
            public bool CreateExecuted { get; private set; }
            public bool SaveChangesExecuted { get; private set; }

            public void Create(Common.Entities.Task entity)
            {
                CreateExecuted = true;
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public Common.Entities.Task GetById(Guid id)
            {
                throw new NotImplementedException();
            }

            public void Initialize(IOrganizationServiceFactory service, Guid userId)
            {
                throw new NotImplementedException();
            }

            public void SaveChanges()
            {
                SaveChangesExecuted = true;
            }
        }

        [TestMethod]
        public void TryCreateTaskForLargeEmployeesNumberLeads_NumberOfEmployeesOver30_TaskCreated()
        {

            var taskRepositoryMock = new TaskRepositoryMock(); 

            var repositoryFactoryMock = new Mock<IRepositoryFactory>();
            repositoryFactoryMock.Setup(pa => pa.Get<Team, ITeamRepository>()).Returns( () =>
            {
                //Team Repository stub
                Mock<ITeamRepository> teamRepositoryMock = new Mock<ITeamRepository>();
                teamRepositoryMock.Setup(s => s.GetSalesTeam()).Returns(new Team() { Id = Guid.NewGuid(), Name = "Sales team" });
                return teamRepositoryMock.Object; 
            });
            repositoryFactoryMock.Setup(pa => pa.Get<Common.Entities.Task, ITaskRepository>()).Returns(() => taskRepositoryMock);

            var service = new NewLeadService(repositoryFactoryMock.Object);
            service.TryCreateTaskForLargeEmployeesNumberLeads(new Lead() {NumberOfEmployees = 31});

            Assert.IsTrue(taskRepositoryMock.CreateExecuted);
            Assert.IsTrue(taskRepositoryMock.SaveChangesExecuted);

        }

        [TestMethod]
        public void TryCreateTaskForLargeEmployeesNumberLeads_NumberOfEmployeesBelow30_TaskNotCreated()
        {
            var taskRepositoryMock = new TaskRepositoryMock();

            var repositoryFactoryMock = new Mock<IRepositoryFactory>();
            repositoryFactoryMock.Setup(pa => pa.Get<Team, ITeamRepository>()).Returns(() =>
            {
                //Team Repository stub
                Mock<ITeamRepository> teamRepositoryMock = new Mock<ITeamRepository>();
                teamRepositoryMock.Setup(s => s.GetSalesTeam()).Returns(new Team() { Id = Guid.NewGuid(), Name = "Sales team" });
                return teamRepositoryMock.Object;
            });
            repositoryFactoryMock.Setup(pa => pa.Get<Common.Entities.Task, ITaskRepository>()).Returns(() => taskRepositoryMock);

            var service = new NewLeadService(repositoryFactoryMock.Object);
            service.TryCreateTaskForLargeEmployeesNumberLeads(new Lead() { NumberOfEmployees = 29 });

            Assert.IsFalse(taskRepositoryMock.CreateExecuted);
            Assert.IsFalse(taskRepositoryMock.SaveChangesExecuted);
        }

        [TestMethod]
        public void TryCreateTaskForLargeEmployeesNumberLeads_SalesTeamDoesNotExist_TaskNotCreated()
        {
            var taskRepositoryMock = new TaskRepositoryMock();

            var repositoryFactoryMock = new Mock<IRepositoryFactory>();
            repositoryFactoryMock.Setup(pa => pa.Get<Team, ITeamRepository>()).Returns(() =>
            {
                //Team Repository stub
                Mock<ITeamRepository> teamRepositoryMock = new Mock<ITeamRepository>();
                teamRepositoryMock.Setup(s => s.GetSalesTeam()).Returns(() => null); 
                return teamRepositoryMock.Object;
            });
            repositoryFactoryMock.Setup(pa => pa.Get<Common.Entities.Task, ITaskRepository>()).Returns(() => taskRepositoryMock);

            var service = new NewLeadService(repositoryFactoryMock.Object);
            service.TryCreateTaskForLargeEmployeesNumberLeads(new Lead() { NumberOfEmployees = 31 });

            Assert.IsFalse(taskRepositoryMock.CreateExecuted);
            Assert.IsFalse(taskRepositoryMock.SaveChangesExecuted);
        }

    }
}
