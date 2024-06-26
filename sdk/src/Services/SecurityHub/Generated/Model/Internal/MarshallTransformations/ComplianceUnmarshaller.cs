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
    /// Response Unmarshaller for Compliance Object
    /// </summary>  
    public class ComplianceUnmarshaller : IUnmarshaller<Compliance, XmlUnmarshallerContext>, IUnmarshaller<Compliance, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Compliance IUnmarshaller<Compliance, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Compliance Unmarshall(JsonUnmarshallerContext context)
        {
            Compliance unmarshalledObject = new Compliance();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AssociatedStandards", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssociatedStandard, AssociatedStandardUnmarshaller>(AssociatedStandardUnmarshaller.Instance);
                    unmarshalledObject.AssociatedStandards = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelatedRequirements", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RelatedRequirements = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityControlId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecurityControlId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityControlParameters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SecurityControlParameter, SecurityControlParameterUnmarshaller>(SecurityControlParameterUnmarshaller.Instance);
                    unmarshalledObject.SecurityControlParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatusReasons", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StatusReason, StatusReasonUnmarshaller>(StatusReasonUnmarshaller.Instance);
                    unmarshalledObject.StatusReasons = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ComplianceUnmarshaller _instance = new ComplianceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComplianceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}