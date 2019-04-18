using System;
using System.Linq;
using Microsoft.Xrm.Sdk;

namespace Chapter01.FooPlugin.Extensions
{
    public static class IPluginExecutionContextExtensions
    {
        public static string ToFormattedString(this IPluginExecutionContext pluginExecutionContext)
        {
            if (pluginExecutionContext == null)
            {
                return string.Empty;
            }

            var target = pluginExecutionContext.InputParameters != null 
                && pluginExecutionContext.InputParameters.Contains(PluginBase.TargetAttributeName) ? pluginExecutionContext.InputParameters[PluginBase.TargetAttributeName] as Entity : null;

            // Format and return the execution context
            var formattedContext = string.Join("; ", new[]
            {
                $"MessageName: {pluginExecutionContext.MessageName}",
                $"PrimaryEntityName: {pluginExecutionContext.PrimaryEntityName}",
                $"SecondaryEntityName: {pluginExecutionContext.SecondaryEntityName}",
                $"IsolationMode: {pluginExecutionContext.IsolationMode}",
                $"Mode: {pluginExecutionContext.Mode}",
                $"Stage: {pluginExecutionContext.Stage}",
                $"IsInTransaction: {pluginExecutionContext.IsInTransaction}",
                $"IsExecutingOffline: {pluginExecutionContext.IsExecutingOffline}",
                $"Depth: {pluginExecutionContext.Depth}",
                $"OrganizationName: {pluginExecutionContext.OrganizationName}",
                $"PrimaryEntityId: {pluginExecutionContext.PrimaryEntityId}",
                $"InitiatingUserId: {pluginExecutionContext.InitiatingUserId}",
                $"UserId: {pluginExecutionContext.UserId}",
                $"Target: {GetFormattedTargetEntity(target)}",        
                $"PreEntityImages: {GetFormattedPreEntityImage(pluginExecutionContext.PreEntityImages)}",
                $"PostEntityImages: { GetFormattedPostEntityImage(pluginExecutionContext.PostEntityImages)}",
                $"InputParameters: { GetFormattedInputParameters(pluginExecutionContext.InputParameters)}",
                $"OutputParameters: {GetFormattedInputParameters(pluginExecutionContext.OutputParameters)}",
            });

            return formattedContext; 
        }

        private static string GetFormattedTargetEntity(Entity target)
        {
            return target?.Attributes?.Count > 0 ? "[" + string.Join(", ", target.Attributes.Select(i => i.Key).ToArray()) + "]" : String.Empty; 

        }

        private static string GetFormattedPreEntityImage(EntityImageCollection preImageCollection)
        {
            if (preImageCollection == null)
            {
                return String.Empty;
            }

            return (preImageCollection?.Count > 0 
                ? "[" + string.Join(", ", preImageCollection.Select(i => i.Key + ": [" + string.Join(", ", preImageCollection[i.Key].Attributes.Select(a => a.Key).ToArray()) + "}").ToArray()) + "]" 
                : String.Empty); 
        }

        private static string GetFormattedPostEntityImage(EntityImageCollection postImageCollection)
        {
            if (postImageCollection == null)
            {
                return String.Empty; 
            }

            return (postImageCollection?.Count > 0 
                ? "[" + string.Join(", ", postImageCollection.Select(i => i.Key + ": [" + string.Join(", ", postImageCollection[i.Key].Attributes.Select(a => a.Key).ToArray()) + "}").ToArray()) + "]" 
                : String.Empty); 
        }

        private static string GetFormattedInputParameters(ParameterCollection inputParameters)
        {
            if (inputParameters == null)
            {
                return string.Empty; 
            }

            return (inputParameters?.Count > 0 ? "[" + string.Join(", ", inputParameters.Select(i => i.Key).ToArray()) + "]" : String.Empty); 
        }

        private static string GetFormattedOutputParameters(ParameterCollection outputParameters)
        {
            if (outputParameters == null)
            {
                return string.Empty;
            }

            return (outputParameters?.Count > 0 ? "[" + string.Join(", ", outputParameters.Select(o => o.Key).ToArray()) + "]" : String.Empty); 
        }
    }
}
