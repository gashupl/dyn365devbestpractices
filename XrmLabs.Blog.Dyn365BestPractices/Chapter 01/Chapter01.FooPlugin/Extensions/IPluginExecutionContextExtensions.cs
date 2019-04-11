using System;
using Microsoft.Xrm.Sdk;

namespace Chapter01.FooPlugin.Extensions
{
    public static class IPluginExecutionContextExtensions
    {
        public static string ToFormattedString(this IPluginExecutionContext pluginExecutionContext)
        {
            throw new NotImplementedException(); 
        } 
    }
}
