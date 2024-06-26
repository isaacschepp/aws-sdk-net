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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ContentModerationDetection Object
    /// </summary>  
    public class ContentModerationDetectionUnmarshaller : IUnmarshaller<ContentModerationDetection, XmlUnmarshallerContext>, IUnmarshaller<ContentModerationDetection, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ContentModerationDetection IUnmarshaller<ContentModerationDetection, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ContentModerationDetection Unmarshall(JsonUnmarshallerContext context)
        {
            ContentModerationDetection unmarshalledObject = new ContentModerationDetection();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ContentTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ContentType, ContentTypeUnmarshaller>(ContentTypeUnmarshaller.Instance);
                    unmarshalledObject.ContentTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DurationMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DurationMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTimestampMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.EndTimestampMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModerationLabel", targetDepth))
                {
                    var unmarshaller = ModerationLabelUnmarshaller.Instance;
                    unmarshalledObject.ModerationLabel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTimestampMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.StartTimestampMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timestamp", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Timestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ContentModerationDetectionUnmarshaller _instance = new ContentModerationDetectionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContentModerationDetectionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}