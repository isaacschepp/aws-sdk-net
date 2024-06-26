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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Paginators for the SSOAdmin service
    ///</summary>
    public interface ISSOAdminPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccountAssignmentCreationStatus operation
        ///</summary>
        IListAccountAssignmentCreationStatusPaginator ListAccountAssignmentCreationStatus(ListAccountAssignmentCreationStatusRequest request);

        /// <summary>
        /// Paginator for ListAccountAssignmentDeletionStatus operation
        ///</summary>
        IListAccountAssignmentDeletionStatusPaginator ListAccountAssignmentDeletionStatus(ListAccountAssignmentDeletionStatusRequest request);

        /// <summary>
        /// Paginator for ListAccountAssignments operation
        ///</summary>
        IListAccountAssignmentsPaginator ListAccountAssignments(ListAccountAssignmentsRequest request);

        /// <summary>
        /// Paginator for ListAccountAssignmentsForPrincipal operation
        ///</summary>
        IListAccountAssignmentsForPrincipalPaginator ListAccountAssignmentsForPrincipal(ListAccountAssignmentsForPrincipalRequest request);

        /// <summary>
        /// Paginator for ListAccountsForProvisionedPermissionSet operation
        ///</summary>
        IListAccountsForProvisionedPermissionSetPaginator ListAccountsForProvisionedPermissionSet(ListAccountsForProvisionedPermissionSetRequest request);

        /// <summary>
        /// Paginator for ListApplicationAccessScopes operation
        ///</summary>
        IListApplicationAccessScopesPaginator ListApplicationAccessScopes(ListApplicationAccessScopesRequest request);

        /// <summary>
        /// Paginator for ListApplicationAssignments operation
        ///</summary>
        IListApplicationAssignmentsPaginator ListApplicationAssignments(ListApplicationAssignmentsRequest request);

        /// <summary>
        /// Paginator for ListApplicationAssignmentsForPrincipal operation
        ///</summary>
        IListApplicationAssignmentsForPrincipalPaginator ListApplicationAssignmentsForPrincipal(ListApplicationAssignmentsForPrincipalRequest request);

        /// <summary>
        /// Paginator for ListApplicationAuthenticationMethods operation
        ///</summary>
        IListApplicationAuthenticationMethodsPaginator ListApplicationAuthenticationMethods(ListApplicationAuthenticationMethodsRequest request);

        /// <summary>
        /// Paginator for ListApplicationGrants operation
        ///</summary>
        IListApplicationGrantsPaginator ListApplicationGrants(ListApplicationGrantsRequest request);

        /// <summary>
        /// Paginator for ListApplicationProviders operation
        ///</summary>
        IListApplicationProvidersPaginator ListApplicationProviders(ListApplicationProvidersRequest request);

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListCustomerManagedPolicyReferencesInPermissionSet operation
        ///</summary>
        IListCustomerManagedPolicyReferencesInPermissionSetPaginator ListCustomerManagedPolicyReferencesInPermissionSet(ListCustomerManagedPolicyReferencesInPermissionSetRequest request);

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        IListInstancesPaginator ListInstances(ListInstancesRequest request);

        /// <summary>
        /// Paginator for ListManagedPoliciesInPermissionSet operation
        ///</summary>
        IListManagedPoliciesInPermissionSetPaginator ListManagedPoliciesInPermissionSet(ListManagedPoliciesInPermissionSetRequest request);

        /// <summary>
        /// Paginator for ListPermissionSetProvisioningStatus operation
        ///</summary>
        IListPermissionSetProvisioningStatusPaginator ListPermissionSetProvisioningStatus(ListPermissionSetProvisioningStatusRequest request);

        /// <summary>
        /// Paginator for ListPermissionSets operation
        ///</summary>
        IListPermissionSetsPaginator ListPermissionSets(ListPermissionSetsRequest request);

        /// <summary>
        /// Paginator for ListPermissionSetsProvisionedToAccount operation
        ///</summary>
        IListPermissionSetsProvisionedToAccountPaginator ListPermissionSetsProvisionedToAccount(ListPermissionSetsProvisionedToAccountRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTrustedTokenIssuers operation
        ///</summary>
        IListTrustedTokenIssuersPaginator ListTrustedTokenIssuers(ListTrustedTokenIssuersRequest request);
    }
}