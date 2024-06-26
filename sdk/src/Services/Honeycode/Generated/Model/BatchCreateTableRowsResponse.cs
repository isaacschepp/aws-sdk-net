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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// This is the response object from the BatchCreateTableRows operation.
    /// </summary>
    public partial class BatchCreateTableRowsResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _createdRows = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<FailedBatchItem> _failedBatchItems = AWSConfigs.InitializeCollections ? new List<FailedBatchItem>() : null;
        private long? _workbookCursor;

        /// <summary>
        /// Gets and sets the property CreatedRows. 
        /// <para>
        /// The map of batch item id to the row id that was created for that item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> CreatedRows
        {
            get { return this._createdRows; }
            set { this._createdRows = value; }
        }

        // Check to see if CreatedRows property is set
        internal bool IsSetCreatedRows()
        {
            return this._createdRows != null && (this._createdRows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailedBatchItems. 
        /// <para>
        ///  The list of batch items in the request that could not be added to the table. Each
        /// element in this list contains one item from the request that could not be added to
        /// the table along with the reason why that item could not be added. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<FailedBatchItem> FailedBatchItems
        {
            get { return this._failedBatchItems; }
            set { this._failedBatchItems = value; }
        }

        // Check to see if FailedBatchItems property is set
        internal bool IsSetFailedBatchItems()
        {
            return this._failedBatchItems != null && (this._failedBatchItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkbookCursor. 
        /// <para>
        /// The updated workbook cursor after adding the new rows at the end of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long WorkbookCursor
        {
            get { return this._workbookCursor.GetValueOrDefault(); }
            set { this._workbookCursor = value; }
        }

        // Check to see if WorkbookCursor property is set
        internal bool IsSetWorkbookCursor()
        {
            return this._workbookCursor.HasValue; 
        }

    }
}