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
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.UserProvidedServiceInstancesEndpoint.UpdateUserProvidedServiceInstance()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/user_provided_service_instances/updating_a_user_provided_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateUserProvidedServiceInstanceRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateUserProvidedServiceInstanceRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateUserProvidedServiceInstanceRequest
    {

        /// <summary> 
        /// <para>A hash that can be used to store credentials</para>
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Credentials
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A name for the service instance</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The url for the syslog_drain to direct to</para>
        /// </summary>
        [JsonProperty("syslog_drain_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SyslogDrainUrl
        {
            get;
            set;
        }
    }
}