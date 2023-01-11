﻿using Altinn.ResourceRegistry.Core.Models;

namespace Altinn.ResourceRegistry.Core.Services.Interfaces
{
    /// <summary>
    /// Interface for the ResourceRegistryService implementation
    /// </summary>
    public interface IResourceRegistry
    {
        /// <summary>
        /// Gets a single resource by its resource identifier if it exists in the resource registry
        /// </summary>
        /// <param name="id">The resource identifier to retrieve</param>
        /// <returns>ServiceResource</returns>
        Task<ServiceResource> GetResource(string id);

        /// <summary>
        /// Creates a service resource in the resource registry if it pass all validation checks
        /// </summary>
        /// <param name="serviceResource">Service resource model to create in the resource registry</param>
        /// <returns>The result of the operation</returns>
        Task CreateResource(ServiceResource serviceResource);

        /// <summary>
        /// Updates a service resource in the resource registry if it pass all validation checks
        /// </summary>
        /// <param name="serviceResource">Service resource model for update in the resource registry</param>
        /// <returns>The result of the operation</returns>
        Task UpdateResource(ServiceResource serviceResource);

        /// <summary>
        /// Deletes a resource from the resource registry
        /// </summary>
        /// <param name="id">The resource identifier to delete</param>
        Task Delete(string id);

        /// <summary>
        /// Allows for searching for resources in the resource registry
        /// </summary>
        /// <param name="resourceSearch">The search model defining the search filter criterias</param>
        /// <returns>A list of service resources found to match the search criterias</returns>
        Task<List<ServiceResource>> Search(ResourceSearch resourceSearch);

        /// <summary>
        /// Allows for storing a policy xacml policy for the resource
        /// </summary>
        /// <param name="serviceResource">The resource</param>
        /// <param name="fileStream">The file stream to the policy file</param>
        /// <returns>Bool if storing the policy was successfull</returns>
        Task<bool> StorePolicy(ServiceResource serviceResource, Stream fileStream);

        /// <summary>
        /// Returns the policy for a service resource
        /// </summary>
        /// <param name="resourceId">The resource id</param>
        /// <returns></returns>
        Task<Stream> GetPolicy(string resourceId);

        /// <summary>
        /// Updates Access management with changes in recource registry
        /// </summary>
        /// <param name="serviceResource">The resource to add to access management</param>
        /// <returns></returns>
        Task<bool> UpdateResourceInAccessManagement(ServiceResource serviceResource);
    }
}