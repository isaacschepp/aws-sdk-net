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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the auto scaling settings of a global secondary index for a replica that
    /// will be modified.
    /// </summary>
    public partial class ReplicaGlobalSecondaryIndexAutoScalingUpdate
    {
        private string _indexName;
        private AutoScalingSettingsUpdate _provisionedReadCapacityAutoScalingUpdate;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the global secondary index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedReadCapacityAutoScalingUpdate.
        /// </summary>
        public AutoScalingSettingsUpdate ProvisionedReadCapacityAutoScalingUpdate
        {
            get { return this._provisionedReadCapacityAutoScalingUpdate; }
            set { this._provisionedReadCapacityAutoScalingUpdate = value; }
        }

        // Check to see if ProvisionedReadCapacityAutoScalingUpdate property is set
        internal bool IsSetProvisionedReadCapacityAutoScalingUpdate()
        {
            return this._provisionedReadCapacityAutoScalingUpdate != null;
        }

    }
}