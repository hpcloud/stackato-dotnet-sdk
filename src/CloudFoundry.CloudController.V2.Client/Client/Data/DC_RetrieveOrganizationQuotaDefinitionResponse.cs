//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.OrganizationQuotaDefinitionsEndpoint.RetrieveOrganizationQuotaDefinition()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/organization_quota_definitions/retrieve_a_particular_organization_quota_definition.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RetrieveOrganizationQuotaDefinitionResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractRetrieveOrganizationQuotaDefinitionResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractRetrieveOrganizationQuotaDefinitionResponse : IResponse
    {
        /// <summary>
        /// Contains the Metadata for this Entity
        /// </summary>
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Name</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Non Basic Services Allowed</para>
        /// </summary>
        [JsonProperty("non_basic_services_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NonBasicServicesAllowed
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Total Services</para>
        /// </summary>
        [JsonProperty("total_services", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalServices
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Total Routes</para>
        /// </summary>
        [JsonProperty("total_routes", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRoutes
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Memory Limit</para>
        /// </summary>
        [JsonProperty("memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Trial Db Allowed</para>
        /// </summary>
        [JsonProperty("trial_db_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic TrialDbAllowed
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Instance Memory Limit</para>
        /// </summary>
        [JsonProperty("instance_memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceMemoryLimit
        {
            get;
            set;
        }
    }
}