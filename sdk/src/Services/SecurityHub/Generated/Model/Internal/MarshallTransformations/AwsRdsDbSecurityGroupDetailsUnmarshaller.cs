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
    /// Response Unmarshaller for AwsRdsDbSecurityGroupDetails Object
    /// </summary>  
    public class AwsRdsDbSecurityGroupDetailsUnmarshaller : IUnmarshaller<AwsRdsDbSecurityGroupDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsRdsDbSecurityGroupDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsRdsDbSecurityGroupDetails IUnmarshaller<AwsRdsDbSecurityGroupDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsRdsDbSecurityGroupDetails Unmarshall(JsonUnmarshallerContext context)
        {
            AwsRdsDbSecurityGroupDetails unmarshalledObject = new AwsRdsDbSecurityGroupDetails();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DbSecurityGroupArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbSecurityGroupArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbSecurityGroupDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbSecurityGroupDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbSecurityGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbSecurityGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ec2SecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbSecurityGroupEc2SecurityGroup, AwsRdsDbSecurityGroupEc2SecurityGroupUnmarshaller>(AwsRdsDbSecurityGroupEc2SecurityGroupUnmarshaller.Instance);
                    unmarshalledObject.Ec2SecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpRanges", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbSecurityGroupIpRange, AwsRdsDbSecurityGroupIpRangeUnmarshaller>(AwsRdsDbSecurityGroupIpRangeUnmarshaller.Instance);
                    unmarshalledObject.IpRanges = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OwnerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsRdsDbSecurityGroupDetailsUnmarshaller _instance = new AwsRdsDbSecurityGroupDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsRdsDbSecurityGroupDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}