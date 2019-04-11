using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Chapter01.FooPlugin.Extensions;
using Microsoft.Xrm.Sdk;

namespace Chapter01.FooPlugin
{
    /// <summary>
    /// Responsiblities: 
    /// Initialization of Tracing & Notification services
    /// Retrieving plugin execution context
    /// Validation of execution context
    /// Serializing and logging execution context in case of error
    /// Registering required dependencies
    /// </summary>
    public abstract class PluginBase : IPlugin
    {

        #region Protected properties

        protected string Name => GetType().FullName;

        /// <summary>
        /// Gets the unsecure plugin configuration
        /// </summary>
        protected string UnsecurePluginConfiguration { get; }

        /// <summary>
        /// Gets the secure plugin configuration
        /// </summary>
        protected string SecurePluginConfiguration { get; }

        #endregion

        protected PluginBase(string unsecureString, string secureString) 
        {
            // Set local state
            this.UnsecurePluginConfiguration = unsecureString;
            this.SecurePluginConfiguration = secureString;
        }

        public void Execute(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            if (tracingService == null)
            {
                throw new ApplicationException("Failed to initialize plugin tracing service");
            }

            IPluginExecutionContext pluginExecutionContext = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            if (pluginExecutionContext == null)
            {
                throw new ApplicationException("Failed to initialize plugin execution context");
            }

            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService organizationService = serviceFactory.CreateOrganizationService(pluginExecutionContext.UserId);

            // Resolve the Azure service bus notification service 
            var notificationService = (IServiceEndpointNotificationService)serviceProvider.GetService(typeof(IServiceEndpointNotificationService));
            if (notificationService == null)
            {
                throw new ApplicationException("Failed to initialize Azure service bus notification service");
            }

            try
            {
                if (this.IsContextValid(pluginExecutionContext))
                {
                    this.Execute(pluginExecutionContext, tracingService);
                }
                else
                {
                    // Perform silent abort
                    tracingService.Trace($"Invalid plugin execution context detected (Plugin: {this.Name})");
                    tracingService.Trace($"Execution context: [{pluginExecutionContext.ToFormattedString()}]");
                    tracingService.Trace("Plugin execution aborted");
                    return;
                }
            }
            catch (InvalidPluginExecutionException)
            {
                throw;
            }
            catch (OutOfMemoryException e)
            {
                throw new InvalidPluginExecutionException(OperationStatus.Failed, e.Message);
            }
            catch (StackOverflowException e)
            {
                throw new InvalidPluginExecutionException(OperationStatus.Failed, e.Message);
            }
            catch (ThreadAbortException e)
            {
                throw new InvalidPluginExecutionException(OperationStatus.Failed, e.Message);
            }
            catch (Exception e)
            {
                tracingService?.Trace($"Plugin failed unexpectedly: '{this.Name}'");
                tracingService.Trace($"Exception: {e}");
                throw new InvalidPluginExecutionException(OperationStatus.Failed, "Sorry, the action failed unexpectedly!");
            }
        }

        #region Abstract methods
        public abstract bool IsContextValid(IPluginExecutionContext context);

        public abstract void Execute(IPluginExecutionContext pluginExecutionContext, ITracingService tracingService);
        #endregion

        protected string GetUnsecurePluginConfigurationValue(string key)
        {
            //TODO: Implement your logic here
            throw new NotImplementedException(); 
        }

        protected string GetSecurePluginConfigurationValue(string key)
        {
            //TODO: Implement your logic here
            throw new NotImplementedException();
        }

    }
}
