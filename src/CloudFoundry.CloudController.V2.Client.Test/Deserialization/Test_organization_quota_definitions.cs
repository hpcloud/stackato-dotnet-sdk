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

using System;
using System.CodeDom.Compiler;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CloudFoundry.CloudController.V2.Client.Data;
using CloudFoundry.CloudController.V2;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class OrganizationQuotaDefinitionsTest
    {

    
        [TestMethod]
        public void TestListAllOrganizationQuotaDefinitionsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""bce3ba9f-d984-4bc8-917d-567c8da87117"",
        ""url"": ""/v2/quota_definitions/bce3ba9f-d984-4bc8-917d-567c8da87117"",
        ""created_at"": ""2015-02-19T03:52:35+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""default"",
        ""non_basic_services_allowed"": true,
        ""total_services"": 100,
        ""total_routes"": 1000,
        ""memory_limit"": 10240,
        ""trial_db_allowed"": false,
        ""instance_memory_limit"": -1
      }
    }
  ]
}";
    
            PagedResponse<ListAllOrganizationQuotaDefinitionsResponse> page = Util.DeserializePage<ListAllOrganizationQuotaDefinitionsResponse>(json);
        
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
        
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
        
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PrevUrl), true);
        
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
        
            
        
            
            
                Assert.AreEqual("bce3ba9f-d984-4bc8-917d-567c8da87117", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/quota_definitions/bce3ba9f-d984-4bc8-917d-567c8da87117", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-02-19T03:52:35+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
                  Assert.AreEqual("default", TestUtil.ToTestableString(page[0].Name), true);
                  Assert.AreEqual("true", TestUtil.ToTestableString(page[0].NonBasicServicesAllowed), true);
                  Assert.AreEqual("100", TestUtil.ToTestableString(page[0].TotalServices), true);
                  Assert.AreEqual("1000", TestUtil.ToTestableString(page[0].TotalRoutes), true);
                  Assert.AreEqual("10240", TestUtil.ToTestableString(page[0].MemoryLimit), true);
                  Assert.AreEqual("false", TestUtil.ToTestableString(page[0].TrialDbAllowed), true);
                  Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].InstanceMemoryLimit), true);
               
               
            
    
        }

    
        [TestMethod]
        public void TestUpdateOrganizationQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""b9b49ba9-459e-466c-b732-f10c72b2a5f1"",
    ""url"": ""/v2/quota_definitions/b9b49ba9-459e-466c-b732-f10c72b2a5f1"",
    ""created_at"": ""2015-02-19T03:52:39+00:00"",
    ""updated_at"": ""2015-02-19T03:52:39+00:00""
  },
  ""entity"": {
    ""name"": ""name-193"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": -1
  }
}";
    
            UpdateOrganizationQuotaDefinitionResponse obj = Util.DeserializeJson<UpdateOrganizationQuotaDefinitionResponse>(json);
        
            Assert.AreEqual("b9b49ba9-459e-466c-b732-f10c72b2a5f1", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/b9b49ba9-459e-466c-b732-f10c72b2a5f1", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:39+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-02-19T03:52:39+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-193", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            
            
        }

    
        [TestMethod]
        public void TestRetrieveOrganizationQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""658f571e-e275-48e6-8fd3-5aa9bbe6b78f"",
    ""url"": ""/v2/quota_definitions/658f571e-e275-48e6-8fd3-5aa9bbe6b78f"",
    ""created_at"": ""2015-02-19T03:52:39+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-194"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": -1
  }
}";
    
            RetrieveOrganizationQuotaDefinitionResponse obj = Util.DeserializeJson<RetrieveOrganizationQuotaDefinitionResponse>(json);
        
            Assert.AreEqual("658f571e-e275-48e6-8fd3-5aa9bbe6b78f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/658f571e-e275-48e6-8fd3-5aa9bbe6b78f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:39+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-194", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            
            
        }

    
        [TestMethod]
        public void TestCreateOrganizationQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""d5f31f44-d6bb-4fea-bbbb-faf0d4ca2920"",
    ""url"": ""/v2/quota_definitions/d5f31f44-d6bb-4fea-bbbb-faf0d4ca2920"",
    ""created_at"": ""2015-02-19T03:52:39+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""gold_quota"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 5,
    ""total_routes"": 10,
    ""memory_limit"": 5120,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": 10240
  }
}";
    
            CreateOrganizationQuotaDefinitionResponse obj = Util.DeserializeJson<CreateOrganizationQuotaDefinitionResponse>(json);
        
            Assert.AreEqual("d5f31f44-d6bb-4fea-bbbb-faf0d4ca2920", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/d5f31f44-d6bb-4fea-bbbb-faf0d4ca2920", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:39+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("gold_quota", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("5", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("10", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("5120", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
            Assert.AreEqual("10240", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            
            
        }

    }
}
