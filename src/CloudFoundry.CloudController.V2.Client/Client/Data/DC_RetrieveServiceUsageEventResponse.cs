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

using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using CloudFoundry.CloudController.V2.Interfaces;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
public class RetrieveServiceUsageEventResponse :IResponse
{

    public Metadata EntityMetadata
    {
    get;
    set;
    }



    [JsonProperty("state", NullValueHandling=NullValueHandling.Ignore)]
    public string State
    {
    get;
    set;
    }

    [JsonProperty("org_guid", NullValueHandling=NullValueHandling.Ignore)]
    public string OrgGuid
    {
    get;
    set;
    }

    [JsonProperty("space_guid", NullValueHandling=NullValueHandling.Ignore)]
    public string SpaceGuid
    {
    get;
    set;
    }

    [JsonProperty("space_name", NullValueHandling=NullValueHandling.Ignore)]
    public string SpaceName
    {
    get;
    set;
    }

    [JsonProperty("service_instance_guid", NullValueHandling=NullValueHandling.Ignore)]
    public string ServiceInstanceGuid
    {
    get;
    set;
    }

    [JsonProperty("service_instance_name", NullValueHandling=NullValueHandling.Ignore)]
    public string ServiceInstanceName
    {
    get;
    set;
    }

    [JsonProperty("service_instance_type", NullValueHandling=NullValueHandling.Ignore)]
    public string ServiceInstanceType
    {
    get;
    set;
    }

    [JsonProperty("service_plan_guid", NullValueHandling=NullValueHandling.Ignore)]
    public string ServicePlanGuid
    {
    get;
    set;
    }

    [JsonProperty("service_plan_name", NullValueHandling=NullValueHandling.Ignore)]
    public string ServicePlanName
    {
    get;
    set;
    }

    [JsonProperty("service_guid", NullValueHandling=NullValueHandling.Ignore)]
    public string ServiceGuid
    {
    get;
    set;
    }

    [JsonProperty("service_label", NullValueHandling=NullValueHandling.Ignore)]
    public string ServiceLabel
    {
    get;
    set;
    }

}
}