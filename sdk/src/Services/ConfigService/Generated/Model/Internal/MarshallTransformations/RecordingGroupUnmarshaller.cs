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
    /// Response Unmarshaller for RecordingGroup Object
    /// </summary>  
    public class RecordingGroupUnmarshaller : IUnmarshaller<RecordingGroup, XmlUnmarshallerContext>, IUnmarshaller<RecordingGroup, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RecordingGroup IUnmarshaller<RecordingGroup, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RecordingGroup Unmarshall(JsonUnmarshallerContext context)
        {
            RecordingGroup unmarshalledObject = new RecordingGroup();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("allSupported", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AllSupported = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("exclusionByResourceTypes", targetDepth))
                {
                    var unmarshaller = ExclusionByResourceTypesUnmarshaller.Instance;
                    unmarshalledObject.ExclusionByResourceTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("includeGlobalResourceTypes", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeGlobalResourceTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recordingStrategy", targetDepth))
                {
                    var unmarshaller = RecordingStrategyUnmarshaller.Instance;
                    unmarshalledObject.RecordingStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ResourceTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RecordingGroupUnmarshaller _instance = new RecordingGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecordingGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}