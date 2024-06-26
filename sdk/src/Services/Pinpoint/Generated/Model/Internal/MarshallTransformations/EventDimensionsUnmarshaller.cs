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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EventDimensions Object
    /// </summary>  
    public class EventDimensionsUnmarshaller : IUnmarshaller<EventDimensions, XmlUnmarshallerContext>, IUnmarshaller<EventDimensions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EventDimensions IUnmarshaller<EventDimensions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EventDimensions Unmarshall(JsonUnmarshallerContext context)
        {
            EventDimensions unmarshalledObject = new EventDimensions();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Attributes", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, AttributeDimension, StringUnmarshaller, AttributeDimensionUnmarshaller>(StringUnmarshaller.Instance, AttributeDimensionUnmarshaller.Instance);
                    unmarshalledObject.Attributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventType", targetDepth))
                {
                    var unmarshaller = SetDimensionUnmarshaller.Instance;
                    unmarshalledObject.EventType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Metrics", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, MetricDimension, StringUnmarshaller, MetricDimensionUnmarshaller>(StringUnmarshaller.Instance, MetricDimensionUnmarshaller.Instance);
                    unmarshalledObject.Metrics = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EventDimensionsUnmarshaller _instance = new EventDimensionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EventDimensionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}