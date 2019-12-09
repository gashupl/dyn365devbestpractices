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
        public void Create_TaskCreated()
        {
            var expectedEntitiesCount = 1;
            var expectedSubject = "Important lead. Please do sales actions ASAP!"; 

            var context = new XrmFakedContext();
            var service = context.GetOrganizationService();

            var taskRepository = new TaskRepository();
            taskRepository.Initialize(GetServiceFactoryMockedObject(service), Guid.NewGuid());

            taskRepository.Create(new Task
            {
                Subject = expectedSubject,
                RegardingObjectId = new EntityReference(Lead.EntityLogicalName, Guid.NewGuid()), 
                OwnerId = new EntityReference(Team.EntityLogicalName, Guid.NewGuid())
            });

            taskRepository.SaveChanges();

            var taskCollection = service.RetrieveMultiple(new QueryExpression() {EntityName = Task.EntityLogicalName, ColumnSet = new ColumnSet(true)});
            Assert.IsNotNull(taskCollection?.Entities);
            Assert.AreEqual(expectedEntitiesCount, taskCollection.Entities.Count);
            Assert.AreEqual(expectedSubject, taskCollection.Entities[0].Attributes["subject"]); 

        }
    }
}
