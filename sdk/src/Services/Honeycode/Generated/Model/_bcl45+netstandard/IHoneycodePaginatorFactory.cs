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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// Paginators for the Honeycode service
    ///</summary>
    public interface IHoneycodePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListTableColumns operation
        ///</summary>
        IListTableColumnsPaginator ListTableColumns(ListTableColumnsRequest request);

        /// <summary>
        /// Paginator for ListTableRows operation
        ///</summary>
        IListTableRowsPaginator ListTableRows(ListTableRowsRequest request);

        /// <summary>
        /// Paginator for ListTables operation
        ///</summary>
        IListTablesPaginator ListTables(ListTablesRequest request);

        /// <summary>
        /// Paginator for QueryTableRows operation
        ///</summary>
        IQueryTableRowsPaginator QueryTableRows(QueryTableRowsRequest request);
    }
}