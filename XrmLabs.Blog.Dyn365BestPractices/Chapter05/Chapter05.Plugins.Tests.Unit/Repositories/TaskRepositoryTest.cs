using System;
using System.Collections.Generic;
using System.Reflection;
using Chapter05.Plugins.Repositories;
using Common.Entities;
using FakeXrmEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Chapter05.Plugins.Tests.Unit.Repositories
{
    [TestClass]
    public class TaskRepositoryTest : RepositoryTestBase
    {
        [TestMethod]
        public void Create_SingleTaskCreated()
        {
            var expectedEntitiesCount = 1;

            var service = GetFakedOrganizationService();
            CreateTaskWithRepository(service, "Test subject");
            var taskCollection = GetTasks(service);

            Assert.IsNotNull(taskCollection?.Entities);
            Assert.AreEqual(expectedEntitiesCount, taskCollection.Entities.Count);

        }

        [TestMethod]
        public void Create_TaskHasValidName()
        {
            var expectedSubject = "Important lead. Please do sales actions ASAP!";

            var service = GetFakedOrganizationService();
            CreateTaskWithRepository(service, expectedSubject);
            var taskCollection = GetTasks(service); 

            Assert.IsNotNull(taskCollection?.Entities?[0].Attributes);
            Assert.AreEqual(expectedSubject, taskCollection.Entities[0].Attributes["subject"]);

        }

        private IOrganizationService GetFakedOrganizationService()
        {
            var context = new XrmFakedContext();
            return context.GetOrganizationService();
        }

        private void CreateTaskWithRepository(IOrganizationService service, string subject)
        {
            var taskRepository = new TaskRepository();
            taskRepository.Initialize(GetServiceFactoryMockedObject(service), Guid.NewGuid());

            taskRepository.Create(new Task
            {
                Subject = subject,
                RegardingObjectId = new EntityReference(Lead.EntityLogicalName, Guid.NewGuid()),
                OwnerId = new EntityReference(Team.EntityLogicalName, Guid.NewGuid())
            });

            taskRepository.SaveChanges();
        }

        private EntityCollection GetTasks(IOrganizationService service)
        {
            return service.RetrieveMultiple(new QueryExpression() { EntityName = Task.EntityLogicalName, ColumnSet = new ColumnSet(true) });
        }

    }
}
