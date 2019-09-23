﻿using System;
using Chapter04.Plugins;
using Chapter04.Plugins.Services;
using Common.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Moq;
using SimpleInjector;

namespace Chapter04.Plugin.Tests
{
    [TestClass]
    public class FooPluginTest
    {
        [TestMethod]
        public void ExecuteTest()
        {

            var inputParameters = new ParameterCollection();
            inputParameters.Add("Target", new Opportunity());
            var pluginExecutionContextMock = new Mock<IPluginExecutionContext>();
            pluginExecutionContextMock.Setup(m => m.InputParameters).Returns(inputParameters);

            var opportunityTestServiceMock = new Mock<IOpportunityTestService>();
            opportunityTestServiceMock.Setup(m => m.DoSomething(It.IsAny<Opportunity>())).Callback(() => 
                {
                    Console.WriteLine("Method executed");
                }); ;

            var container = new Container();
            container.Options.AllowOverridingRegistrations = true;
            container.Register<IOpportunityTestService>(() => opportunityTestServiceMock.Object);

            var fooPlugin = new Plugins.FooPlugin(String.Empty, String.Empty);
            fooPlugin.Execute(pluginExecutionContextMock.Object, container); 

        }
    }
}
