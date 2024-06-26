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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OrganizationConformancePack Object
    /// </summary>  
    public class OrganizationConformancePackUnmarshaller : IUnmarshaller<OrganizationConformancePack, XmlUnmarshallerContext>, IUnmarshaller<OrganizationConformancePack, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OrganizationConformancePack IUnmarshaller<OrganizationConformancePack, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OrganizationConformancePack Unmarshall(JsonUnmarshallerContext context)
        {
            OrganizationConformancePack unmarshalledObject = new OrganizationConformancePack();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ConformancePackInputParameters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ConformancePackInputParameter, ConformancePackInputParameterUnmarshaller>(ConformancePackInputParameterUnmarshaller.Instance);
                    unmarshalledObject.ConformancePackInputParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeliveryS3Bucket", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeliveryS3Bucket = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeliveryS3KeyPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeliveryS3KeyPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExcludedAccounts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExcludedAccounts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationConformancePackArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrganizationConformancePackArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationConformancePackName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrganizationConformancePackName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OrganizationConformancePackUnmarshaller _instance = new OrganizationConformancePackUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OrganizationConformancePackUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}