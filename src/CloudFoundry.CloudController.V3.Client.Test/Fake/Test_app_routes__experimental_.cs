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

using CloudFoundry.CloudController.V3.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class AppRoutesEndpoint
{
        [TestMethod]
        public void ListRoutesTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""pagination"": {
    ""total_results"": 2,
    ""first"": {
      ""href"": ""/v3/apps/guid-52ae6c97-4ba6-49a5-ae9e-24b1bebd99a7/routes?page=1=50""
    },
    ""last"": {
      ""href"": ""/v3/apps/guid-52ae6c97-4ba6-49a5-ae9e-24b1bebd99a7/routes?page=1=50""
    },
    ""next"": null,
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""ac884a9e-0a29-4f63-8276-0e03d6559dfe"",
      ""host"": ""host-16"",
      ""path"": """",
      ""created_at"": ""2015-06-30T07:10:48Z"",
      ""updated_at"": null,
      ""_links"": {
        ""space"": {
          ""href"": ""/v2/spaces/585f9880-39b8-4eaa-ab1f-b8264fc344d5""
        },
        ""domain"": {
          ""href"": ""/v2/domains/d5fdcc0b-0a6e-4351-b013-50996e481920""
        }
      }
    },
    {
      ""guid"": ""ad825658-2b6e-4f4f-9778-716012c9b973"",
      ""host"": ""host-17"",
      ""path"": ""/foo/bar"",
      ""created_at"": ""2015-06-30T07:10:48Z"",
      ""updated_at"": null,
      ""_links"": {
        ""space"": {
          ""href"": ""/v2/spaces/585f9880-39b8-4eaa-ab1f-b8264fc344d5""
        },
        ""domain"": {
          ""href"": ""/v2/domains/3afae5b6-559f-47b2-ad70-e05bf858fe74""
        }
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.AppRoutes.ListRoutes(guid).Result;

                Assert.AreEqual("ac884a9e-0a29-4f63-8276-0e03d6559dfe", TestUtil.ToTestableString(obj[0].Guid), true);
                Assert.AreEqual("host-16", TestUtil.ToTestableString(obj[0].Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Path), true);
                Assert.AreEqual("2015-06-30T07:10:48Z", TestUtil.ToTestableString(obj[0].CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].UpdatedAt), true);
                Assert.AreEqual("ad825658-2b6e-4f4f-9778-716012c9b973", TestUtil.ToTestableString(obj[1].Guid), true);
                Assert.AreEqual("host-17", TestUtil.ToTestableString(obj[1].Host), true);
                Assert.AreEqual("/foo/bar", TestUtil.ToTestableString(obj[1].Path), true);
                Assert.AreEqual("2015-06-30T07:10:48Z", TestUtil.ToTestableString(obj[1].CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].UpdatedAt), true);

            }
        }

        [TestMethod]
        public void UnmapRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UnmapRouteRequest value = new UnmapRouteRequest();


                cfClient.AppRoutes.UnmapRoute(guid, value).Wait();

            }
        }

    }
}