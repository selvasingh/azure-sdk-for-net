// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class ResourceProviderOperationDetailsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of resource providers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Resource identity.
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            public static IPage<ResourceProviderOperationDefinition> List(this IResourceProviderOperationDetailsOperations operations, string resourceProviderNamespace, string apiVersion)
            {
                return Task.Factory.StartNew(s => ((IResourceProviderOperationDetailsOperations)s).ListAsync(resourceProviderNamespace, apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of resource providers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Resource identity.
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceProviderOperationDefinition>> ListAsync( this IResourceProviderOperationDetailsOperations operations, string resourceProviderNamespace, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceProviderNamespace, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of resource providers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ResourceProviderOperationDefinition> ListNext(this IResourceProviderOperationDetailsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IResourceProviderOperationDetailsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of resource providers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceProviderOperationDefinition>> ListNextAsync( this IResourceProviderOperationDetailsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}