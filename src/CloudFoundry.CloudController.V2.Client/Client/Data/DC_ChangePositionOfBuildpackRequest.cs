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
public class ChangePositionOfBuildpackRequest
{



    [JsonProperty("position", NullValueHandling=NullValueHandling.Ignore)]
    public int? Position
    {
    get;
    set;
    }

    [JsonProperty("name", NullValueHandling=NullValueHandling.Ignore)]
    public string Name
    {
    get;
    set;
    }

    [JsonProperty("enabled", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic Enabled
    {
    get;
    set;
    }

    [JsonProperty("locked", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic Locked
    {
    get;
    set;
    }

    [JsonProperty("filename", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic Filename
    {
    get;
    set;
    }

}
}