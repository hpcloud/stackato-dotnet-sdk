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
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.AppsEndpoint.GetInstanceInformationForStartedApp()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/apps/get_the_instance_information_for_a_started_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetInstanceInformationForStartedAppResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractGetInstanceInformationForStartedAppResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetInstanceInformationForStartedAppResponse : IResponse
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
        /// <para>The State</para>
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Since</para>
        /// </summary>
        [JsonProperty("since", NullValueHandling = NullValueHandling.Ignore)]
        public double? Since
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Debug Ip</para>
        /// </summary>
        [JsonProperty("debug_ip", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DebugIp
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Debug Port</para>
        /// </summary>
        [JsonProperty("debug_port", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DebugPort
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Console Ip</para>
        /// </summary>
        [JsonProperty("console_ip", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic ConsoleIp
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Console Port</para>
        /// </summary>
        [JsonProperty("console_port", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic ConsolePort
        {
            get;
            set;
        }
    }
}