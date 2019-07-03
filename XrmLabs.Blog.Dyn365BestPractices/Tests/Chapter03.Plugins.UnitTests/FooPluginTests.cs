using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Chapter03.Plugins.UnitTests
{
    [TestClass]
    public class FooPluginTests
    {
        [TestMethod]
        public void Execute_IsFactoryCreated()
        {
            Mock<IServiceProvider> serviceProviderMock = new Mock<IServiceProvider>(); 
            FooPlugin plugin = new FooPlugin(String.Empty, String.Empty);
            plugin.Execute(serviceProviderMock.Object); 
        }
    }
}
