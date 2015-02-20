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
    public class SecurityGroupsEndpoint : BaseEndpoint
    {
        public SecurityGroupsEndpoint(CloudFoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }

        /// <summary>
        /// Delete a Particular Security Group
        /// </summary>
        public async Task DeleteSecurityGroup(Guid? guid)
        {
            string route = string.Format("/v2/security_groups/{0}", guid);
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
        /// List all Spaces for the Security Group
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForSecurityGroupResponse>> ListAllSpacesForSecurityGroup(Guid? guid)
        {
            return await ListAllSpacesForSecurityGroup(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllSpacesForSecurityGroupResponse>> ListAllSpacesForSecurityGroup(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/security_groups/{0}/spaces", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpacesForSecurityGroupResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Space with the Security Group
        /// </summary>
        public async Task<AssociateSpaceWithSecurityGroupResponse> AssociateSpaceWithSecurityGroup(Guid? guid, Guid? space_guid)
        {
            string route = string.Format("/v2/security_groups/{0}/spaces/{1}", guid, space_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateSpaceWithSecurityGroupResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Space from the Security Group
        /// </summary>
        public async Task<RemoveSpaceFromSecurityGroupResponse> RemoveSpaceFromSecurityGroup(Guid? guid, Guid? space_guid)
        {
            string route = string.Format("/v2/security_groups/{0}/spaces/{1}", guid, space_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveSpaceFromSecurityGroupResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Security Groups
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSecurityGroupsResponse>> ListAllSecurityGroups()
        {
            return await ListAllSecurityGroups(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllSecurityGroupsResponse>> ListAllSecurityGroups(RequestOptions options)
        {
            string route = "/v2/security_groups";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSecurityGroupsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Updating a Security Group
        /// </summary>
        public async Task<UpdateSecurityGroupResponse> UpdateSecurityGroup(Guid? guid, UpdateSecurityGroupRequest value)
        {
            string route = string.Format("/v2/security_groups/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateSecurityGroupResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Creating a Security Group
        /// </summary>
        public async Task<CreateSecurityGroupResponse> CreateSecurityGroup(CreateSecurityGroupRequest value)
        {
            string route = "/v2/security_groups";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateSecurityGroupResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Security Group
        /// </summary>
        public async Task<RetrieveSecurityGroupResponse> RetrieveSecurityGroup(Guid? guid)
        {
            string route = string.Format("/v2/security_groups/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveSecurityGroupResponse>(await response.ReadContentAsStringAsync());
        }
    }
}