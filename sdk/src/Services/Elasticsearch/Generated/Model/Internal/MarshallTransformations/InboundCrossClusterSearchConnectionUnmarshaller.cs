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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Elasticsearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Elasticsearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InboundCrossClusterSearchConnection Object
    /// </summary>  
    public class InboundCrossClusterSearchConnectionUnmarshaller : IUnmarshaller<InboundCrossClusterSearchConnection, XmlUnmarshallerContext>, IUnmarshaller<InboundCrossClusterSearchConnection, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InboundCrossClusterSearchConnection IUnmarshaller<InboundCrossClusterSearchConnection, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InboundCrossClusterSearchConnection Unmarshall(JsonUnmarshallerContext context)
        {
            InboundCrossClusterSearchConnection unmarshalledObject = new InboundCrossClusterSearchConnection();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ConnectionStatus", targetDepth))
                {
                    var unmarshaller = InboundCrossClusterSearchConnectionStatusUnmarshaller.Instance;
                    unmarshalledObject.ConnectionStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CrossClusterSearchConnectionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CrossClusterSearchConnectionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DestinationDomainInfo", targetDepth))
                {
                    var unmarshaller = DomainInformationUnmarshaller.Instance;
                    unmarshalledObject.DestinationDomainInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceDomainInfo", targetDepth))
                {
                    var unmarshaller = DomainInformationUnmarshaller.Instance;
                    unmarshalledObject.SourceDomainInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InboundCrossClusterSearchConnectionUnmarshaller _instance = new InboundCrossClusterSearchConnectionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InboundCrossClusterSearchConnectionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}