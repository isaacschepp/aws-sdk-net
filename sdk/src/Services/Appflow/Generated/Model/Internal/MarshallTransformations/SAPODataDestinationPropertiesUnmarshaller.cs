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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SAPODataDestinationProperties Object
    /// </summary>  
    public class SAPODataDestinationPropertiesUnmarshaller : IUnmarshaller<SAPODataDestinationProperties, XmlUnmarshallerContext>, IUnmarshaller<SAPODataDestinationProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SAPODataDestinationProperties IUnmarshaller<SAPODataDestinationProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SAPODataDestinationProperties Unmarshall(JsonUnmarshallerContext context)
        {
            SAPODataDestinationProperties unmarshalledObject = new SAPODataDestinationProperties();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("errorHandlingConfig", targetDepth))
                {
                    var unmarshaller = ErrorHandlingConfigUnmarshaller.Instance;
                    unmarshalledObject.ErrorHandlingConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("idFieldNames", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.IdFieldNames = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("objectPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ObjectPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("successResponseHandlingConfig", targetDepth))
                {
                    var unmarshaller = SuccessResponseHandlingConfigUnmarshaller.Instance;
                    unmarshalledObject.SuccessResponseHandlingConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("writeOperationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WriteOperationType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SAPODataDestinationPropertiesUnmarshaller _instance = new SAPODataDestinationPropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SAPODataDestinationPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}