﻿using System;
using System.Threading;
using System.Xml;
using Chapter04.Plugins.Dependencies;
using Chapter04.Plugins.Repositories;
using Chapter04.Plugins.Services;
using Microsoft.Xrm.Sdk;
using SimpleInjector;

namespace Chapter04.FooPlugin
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
        #region Constants
        public const string TargetAttributeName = "Target";
        #endregion

        #region Protected properties
        /// <summary>
        /// Gets the unsecure plugin configuration
        /// </summary>
        protected string UnsecurePluginConfiguration { get; }

        /// <summary>
        /// Gets the secure plugin configuration
        /// </summary>
        protected string SecurePluginConfiguration { get; }

       // public abstract IDependencyLoader DependencyLoader { get; protected set; }
        #endregion

        #region Constructor
        protected PluginBase(string unsecureString, string secureString)
        {
            // Set local state
            this.UnsecurePluginConfiguration = unsecureString;
            this.SecurePluginConfiguration = secureString;
        }
        #endregion

        #region IPlugin interface implementation
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
            if (serviceFactory == null)
            {
                throw new ApplicationException("Failed to initialize plugin serviceFactory");
            }

            try
            {
                var container = new Container();

                container.Register<ITracingService>(() => tracingService);
                container.Register<IPluginExecutionContext>(() => pluginExecutionContext);
                container.Register<IOrganizationServiceFactory>(() => serviceFactory);
                container.Register<IRepositoryFactory>(() => new RepositoryFactory(container));
                container.Register<IServicesFactory>(() => new ServicesFactory(container));

                this.RegisterDependencies(container);

                if (this.IsContextValid(pluginExecutionContext))
                {
                    this.Execute(pluginExecutionContext, container);
                }
                else
                {
                    tracingService.Trace($"Invalid plugin execution context detected (Plugin: {this.Name})");
                    tracingService.Trace("Plugin execution aborted");
                    throw new InvalidPluginExecutionException("Invalid plugin execution context detected");
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
        #endregion

        #region Abstract methods
        public abstract bool IsContextValid(IPluginExecutionContext context);

        public abstract void Execute(IPluginExecutionContext pluginExecutionContext, Container container);

        public abstract void RegisterDependencies(Container container); 

        #endregion

        #region Protected methods
        protected string Name => GetType().FullName;

        protected T GetTargetEntity<T>(IPluginExecutionContext pluginExecutionContext) where T : Entity
        {
            if (pluginExecutionContext.InputParameters.Contains(TargetAttributeName) && pluginExecutionContext.InputParameters[TargetAttributeName] is Entity)
            {
                return ((Entity)pluginExecutionContext.InputParameters[TargetAttributeName])?.ToEntity<T>();
            }
            else
            {
                throw new InvalidPluginExecutionException(OperationStatus.Failed, "Missing target value or target is not an Entity");
            }

        }

        protected T GetPreImage<T>(IPluginExecutionContext pluginExecutionContext, string preImageName) where T : Entity
        {
            if (pluginExecutionContext.PreEntityImages.Contains(preImageName))
            {
                return pluginExecutionContext.PreEntityImages[preImageName].ToEntity<T>();
            }
            else
            {
                throw new InvalidPluginExecutionException(OperationStatus.Failed, $"Missing pre entity named {preImageName}");
            }

        }

        protected T GetPostImage<T>(IPluginExecutionContext pluginExecutionContext, string postImageName) where T : Entity
        {
            if (pluginExecutionContext.PostEntityImages.Contains(postImageName))
            {
                return pluginExecutionContext.PreEntityImages[postImageName].ToEntity<T>();
            }
            else
            {
                throw new InvalidPluginExecutionException(OperationStatus.Failed, $"Missing pre entity named {postImageName}");
            }
        }

        protected string GetUnsecurePluginConfigurationValue(string key)
        {
            return this.GetPluginConfgiurationValue(this.UnsecurePluginConfiguration, key);
        }

        protected string GetSecurePluginConfigurationValue(string key)
        {
            return this.GetPluginConfgiurationValue(this.SecurePluginConfiguration, key);
        }
        #endregion

        #region Private methods
        private string GetPluginConfgiurationValue(string config, string key)
        {
            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(this.UnsecurePluginConfiguration))
            {
                return null;
            }

            try
            {
                var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(config);
                var xmlNode = xmlDocument.SelectSingleNode($"configuration/appSettings/add[@key='{key}']");
                return xmlNode?.Attributes?["value"]?.InnerText;
            }
            catch (Exception e)
            {
                throw new FormatException("Unable to parse XML configuration", e);
            }
        }
        #endregion


    }
}
