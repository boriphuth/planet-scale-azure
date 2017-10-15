﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.SqlDatabase.ElasticScale.ShardManagement {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class PerformanceCounters {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PerformanceCounters() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.SqlDatabase.ElasticScale.ShardManagement.PerformanceCounters", typeof(PerformanceCounters).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DDR operations/sec.
        /// </summary>
        internal static string DdrOperationsPerSecDisplayName {
            get {
                return ResourceManager.GetString("DdrOperationsPerSecDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rate of data dependent routing (DDR) operations for this shard map.
        /// </summary>
        internal static string DdrOperationsPerSecHelpText {
            get {
                return ResourceManager.GetString("DdrOperationsPerSecHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mappings added or updated in cache/sec.
        /// </summary>
        internal static string MappingsAddOrUpdatePerSecDisplayName {
            get {
                return ResourceManager.GetString("MappingsAddOrUpdatePerSecDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rate at which mappings are being added or updated in cache for this shard map.
        /// </summary>
        internal static string MappingsAddOrUpdatePerSecHelpText {
            get {
                return ResourceManager.GetString("MappingsAddOrUpdatePerSecHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cached mappings.
        /// </summary>
        internal static string MappingsCountDisplayName {
            get {
                return ResourceManager.GetString("MappingsCountDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of mappings cached for this shard map.
        /// </summary>
        internal static string MappingsCountHelpText {
            get {
                return ResourceManager.GetString("MappingsCountHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapping lookup cache misses/sec.
        /// </summary>
        internal static string MappingsLookupFailedPerSecDisplayName {
            get {
                return ResourceManager.GetString("MappingsLookupFailedPerSecDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rate of failed cache lookup operations for mappings in this shard map.
        /// </summary>
        internal static string MappingsLookupFailedPerSecHelpText {
            get {
                return ResourceManager.GetString("MappingsLookupFailedPerSecHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapping lookup cache hits/sec.
        /// </summary>
        internal static string MappingsLookupSucceededPerSecDisplayName {
            get {
                return ResourceManager.GetString("MappingsLookupSucceededPerSecDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rate of successful cache lookup operations for mappings in this shard map.
        /// </summary>
        internal static string MappingsLookupSucceededPerSecHelpText {
            get {
                return ResourceManager.GetString("MappingsLookupSucceededPerSecHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mappings removed from cache/sec.
        /// </summary>
        internal static string MappingsRemovePerSecDisplayName {
            get {
                return ResourceManager.GetString("MappingsRemovePerSecDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rate at which mappings are being removed from cache for this shard map.
        /// </summary>
        internal static string MappingsRemovePerSecHelpText {
            get {
                return ResourceManager.GetString("MappingsRemovePerSecHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performance Monitor Users.
        /// </summary>
        internal static string PerformanceMonitorUsersGroupName {
            get {
                return ResourceManager.GetString("PerformanceMonitorUsersGroupName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Elastic Database: Shard Management.
        /// </summary>
        internal static string ShardManagementPerformanceCounterCategory {
            get {
                return ResourceManager.GetString("ShardManagementPerformanceCounterCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performance counters for tracking shard management operations and caching.
        /// </summary>
        internal static string ShardManagementPerformanceCounterCategoryHelp {
            get {
                return ResourceManager.GetString("ShardManagementPerformanceCounterCategoryHelp", resourceCulture);
            }
        }
    }
}