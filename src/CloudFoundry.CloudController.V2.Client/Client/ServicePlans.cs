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

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V2.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServicePlansEndpoint : BaseEndpoint
    {
        public ServicePlansEndpoint(CloudFoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }

        /// <summary>
        /// Updating a Service Plan (deprecated)
        /// </summary>
        public async Task<UpdateServicePlanDeprecatedResponse> UpdateServicePlanDeprecated(UpdateServicePlanDeprecatedRequest value)
        {
            string route = "/v2/service_plans";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateServicePlanDeprecatedResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Service Instances for the Service Plan
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceInstancesForServicePlanResponse>> ListAllServiceInstancesForServicePlan(Guid? guid)
        {
            return await ListAllServiceInstancesForServicePlan(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllServiceInstancesForServicePlanResponse>> ListAllServiceInstancesForServicePlan(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/service_plans/{0}/service_instances", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceInstancesForServicePlanResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Service Plans
        /// </summary>
        public async Task DeleteServicePlans(Guid? guid)
        {
            string route = string.Format("/v2/service_plans/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// List all Service Plans
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicePlansResponse>> ListAllServicePlans()
        {
            return await ListAllServicePlans(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllServicePlansResponse>> ListAllServicePlans(RequestOptions options)
        {
            string route = "/v2/service_plans";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServicePlansResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Service Plan
        /// </summary>
        public async Task<RetrieveServicePlanResponse> RetrieveServicePlan(Guid? guid)
        {
            string route = string.Format("/v2/service_plans/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveServicePlanResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Creating a Service Plan (deprecated)
        /// </summary>
        public async Task<CreateServicePlanDeprecatedResponse> CreateServicePlanDeprecated(CreateServicePlanDeprecatedRequest value)
        {
            string route = "/v2/service_plans";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateServicePlanDeprecatedResponse>(await response.ReadContentAsStringAsync());
        }
    }
}