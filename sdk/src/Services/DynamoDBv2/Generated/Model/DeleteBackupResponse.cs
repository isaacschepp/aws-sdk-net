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
    /// This is the response object from the DeleteBackup operation.
    /// </summary>
    public partial class DeleteBackupResponse : AmazonWebServiceResponse
    {
        private BackupDescription _backupDescription;

        /// <summary>
        /// Gets and sets the property BackupDescription. 
        /// <para>
        /// Contains the description of the backup created for the table.
        /// </para>
        /// </summary>
        public BackupDescription BackupDescription
        {
            get { return this._backupDescription; }
            set { this._backupDescription = value; }
        }

        // Check to see if BackupDescription property is set
        internal bool IsSetBackupDescription()
        {
            return this._backupDescription != null;
        }

    }
}