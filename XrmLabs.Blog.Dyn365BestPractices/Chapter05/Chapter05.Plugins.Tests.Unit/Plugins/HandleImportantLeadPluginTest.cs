using System;
using System.Collections.Generic;
using Chapter05.FooPlugin;
using Chapter05.Plugins.Services;
using Chapter05.Plugins.Services.Common;
using Common.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Moq;
using SimpleInjector;

namespace Chapter05.Plugins.Tests.Unit.Plugins
{
    [TestClass]
    public class HandleImportantLeadPluginTest
    {

        private class NewLeadServiceMock : INewLeadService
        {
            public bool TryCreateTaskForLargeEmployeesNumberLeadsExecuted { get; private set; }


            public void TryCreateTaskForLargeEmployeesNumberLeads(Lead lead)
            {
                TryCreateTaskForLargeEmployeesNumberLeadsExecuted = true; 
            }
        }

        [TestMethod]
        public void IsValid_ValidContext_ReturnsTrue()
        {
            Mock<IPluginExecutionContext> pluginContextMock = new Mock<IPluginExecutionContext>();
            pluginContextMock.SetupGet(c => c.PrimaryEntityName).Returns(Lead.EntityLogicalName);
            pluginContextMock.SetupGet(c => c.MessageName).Returns("Create");

            var plugin = new HandleImportantLeadPlugin(String.Empty, String.Empty);
            var isValid = plugin.IsContextValid(pluginContextMock.Object);
            Assert.IsTrue(isValid); 
        }

        [TestMethod]
        public void IsValid_InvalidEntity_ReturnsFalse()
        {
            Mock<IPluginExecutionContext> pluginContextMock = new Mock<IPluginExecutionContext>();
            pluginContextMock.SetupGet(c => c.PrimaryEntityName).Returns(Account.EntityLogicalName);
            pluginContextMock.SetupGet(c => c.MessageName).Returns("Create");

            var plugin = new HandleImportantLeadPlugin(String.Empty, String.Empty);
            var isValid = plugin.IsContextValid(pluginContextMock.Object);
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsValid_InvalidMessage_ReturnsFalse()
        {
            Mock<IPluginExecutionContext> pluginContextMock = new Mock<IPluginExecutionContext>();
            pluginContextMock.SetupGet(c => c.PrimaryEntityName).Returns(Lead.EntityLogicalName);
            pluginContextMock.SetupGet(c => c.MessageName).Returns("Delete");

            var plugin = new HandleImportantLeadPlugin(String.Empty, String.Empty);
            var isValid = plugin.IsContextValid(pluginContextMock.Object);
            Assert.IsFalse(isValid);
        }


        [TestMethod]
        public void Execute_ExecuteRequiredMethods()
        {
            var newLeadServiceMock = new NewLeadServiceMock(); 
            Mock<IServicesFactory> servicesFactory = new Mock<IServicesFactory>();
            servicesFactory.Setup(f => f.Get<INewLeadService>()).Returns(newLeadServiceMock); 

            var container = new Container();
            container.Register<IServicesFactory>(() => servicesFactory.Object); 

            Mock<IPluginExecutionContext> pluginContextMock = new Mock<IPluginExecutionContext>();
            pluginContextMock.SetupGet(c => c.PrimaryEntityName).Returns(Lead.EntityLogicalName);
            pluginContextMock.SetupGet(c => c.MessageName).Returns("Create");
            pluginContextMock.SetupGet(c => c.InputParameters).Returns(new ParameterCollection()
            {
                new KeyValuePair<string, object>(PluginBase.TargetAttributeName, new Lead())
            }); 


            var plugin = new HandleImportantLeadPlugin(String.Empty, String.Empty);
            plugin.Execute(pluginContextMock.Object, container);

            Assert.IsTrue(newLeadServiceMock.TryCreateTaskForLargeEmployeesNumberLeadsExecuted); 
        }
    }
}
