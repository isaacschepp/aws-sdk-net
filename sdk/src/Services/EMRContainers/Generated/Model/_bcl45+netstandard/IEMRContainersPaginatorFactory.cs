/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Paginators for the EMRContainers service
    ///</summary>
    public interface IEMRContainersPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListJobRuns operation
        ///</summary>
        IListJobRunsPaginator ListJobRuns(ListJobRunsRequest request);

        /// <summary>
        /// Paginator for ListJobTemplates operation
        ///</summary>
        IListJobTemplatesPaginator ListJobTemplates(ListJobTemplatesRequest request);

        /// <summary>
        /// Paginator for ListManagedEndpoints operation
        ///</summary>
        IListManagedEndpointsPaginator ListManagedEndpoints(ListManagedEndpointsRequest request);

        /// <summary>
        /// Paginator for ListSecurityConfigurations operation
        ///</summary>
        IListSecurityConfigurationsPaginator ListSecurityConfigurations(ListSecurityConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListVirtualClusters operation
        ///</summary>
        IListVirtualClustersPaginator ListVirtualClusters(ListVirtualClustersRequest request);
    }
}