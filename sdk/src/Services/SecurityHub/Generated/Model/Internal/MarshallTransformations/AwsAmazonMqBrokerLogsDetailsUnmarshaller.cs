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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsAmazonMqBrokerLogsDetails Object
    /// </summary>  
    public class AwsAmazonMqBrokerLogsDetailsUnmarshaller : IUnmarshaller<AwsAmazonMqBrokerLogsDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsAmazonMqBrokerLogsDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsAmazonMqBrokerLogsDetails IUnmarshaller<AwsAmazonMqBrokerLogsDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsAmazonMqBrokerLogsDetails Unmarshall(JsonUnmarshallerContext context)
        {
            AwsAmazonMqBrokerLogsDetails unmarshalledObject = new AwsAmazonMqBrokerLogsDetails();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Audit", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Audit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AuditLogGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AuditLogGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("General", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.General = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GeneralLogGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GeneralLogGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Pending", targetDepth))
                {
                    var unmarshaller = AwsAmazonMqBrokerLogsPendingDetailsUnmarshaller.Instance;
                    unmarshalledObject.Pending = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsAmazonMqBrokerLogsDetailsUnmarshaller _instance = new AwsAmazonMqBrokerLogsDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsAmazonMqBrokerLogsDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}