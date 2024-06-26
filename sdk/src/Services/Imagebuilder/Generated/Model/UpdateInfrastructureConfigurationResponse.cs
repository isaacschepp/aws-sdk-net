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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// This is the response object from the UpdateInfrastructureConfiguration operation.
    /// </summary>
    public partial class UpdateInfrastructureConfigurationResponse : AmazonWebServiceResponse
    {
        private string _clientToken;
        private string _infrastructureConfigurationArn;
        private string _requestId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token that uniquely identifies the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property InfrastructureConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the infrastructure configuration that was updated
        /// by this request.
        /// </para>
        /// </summary>
        public string InfrastructureConfigurationArn
        {
            get { return this._infrastructureConfigurationArn; }
            set { this._infrastructureConfigurationArn = value; }
        }

        // Check to see if InfrastructureConfigurationArn property is set
        internal bool IsSetInfrastructureConfigurationArn()
        {
            return this._infrastructureConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The request ID that uniquely identifies this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

    }
}