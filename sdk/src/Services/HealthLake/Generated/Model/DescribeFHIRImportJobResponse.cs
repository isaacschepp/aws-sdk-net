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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// This is the response object from the DescribeFHIRImportJob operation.
    /// </summary>
    public partial class DescribeFHIRImportJobResponse : AmazonWebServiceResponse
    {
        private ImportJobProperties _importJobProperties;

        /// <summary>
        /// Gets and sets the property ImportJobProperties. 
        /// <para>
        /// The properties of the Import job request, including the ID, ARN, name, status of the
        /// job, and the progress report of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportJobProperties ImportJobProperties
        {
            get { return this._importJobProperties; }
            set { this._importJobProperties = value; }
        }

        // Check to see if ImportJobProperties property is set
        internal bool IsSetImportJobProperties()
        {
            return this._importJobProperties != null;
        }

    }
}