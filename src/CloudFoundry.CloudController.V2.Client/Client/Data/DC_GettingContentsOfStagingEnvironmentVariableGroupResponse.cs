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
public class GettingContentsOfStagingEnvironmentVariableGroupResponse :IResponse
{

    public Metadata EntityMetadata
    {
    get;
    set;
    }



    [JsonProperty("abc", NullValueHandling=NullValueHandling.Ignore)]
    public int? Abc
    {
    get;
    set;
    }

    [JsonProperty("do-re-me", NullValueHandling=NullValueHandling.Ignore)]
    public string Doreme
    {
    get;
    set;
    }

}
}