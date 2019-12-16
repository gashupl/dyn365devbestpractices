using System;
using FakeXrmEasy;
using Microsoft.Xrm.Sdk;
using Moq;

namespace Chapter05.Plugins.Tests.Unit.Repositories
{
    public abstract class RepositoryTestBase
    {

        protected IOrganizationServiceFactory GetServiceFactoryMockedObject(XrmFakedContext context)
        {
            var service = context.GetOrganizationService();

            Mock<IOrganizationServiceFactory> serviceFactoryMock = new Mock<IOrganizationServiceFactory>();
            serviceFactoryMock.Setup(s => s.CreateOrganizationService(It.IsAny<Guid>())).Returns(service);
            return serviceFactoryMock.Object;
        }

        protected IOrganizationServiceFactory GetServiceFactoryMockedObject(IOrganizationService service)
        {

            Mock<IOrganizationServiceFactory> serviceFactoryMock = new Mock<IOrganizationServiceFactory>();
            serviceFactoryMock.Setup(s => s.CreateOrganizationService(It.IsAny<Guid>())).Returns(service);
            return serviceFactoryMock.Object;
        }
    }
}
