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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DolbyVision Object
    /// </summary>  
    public class DolbyVisionUnmarshaller : IUnmarshaller<DolbyVision, XmlUnmarshallerContext>, IUnmarshaller<DolbyVision, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DolbyVision IUnmarshaller<DolbyVision, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DolbyVision Unmarshall(JsonUnmarshallerContext context)
        {
            DolbyVision unmarshalledObject = new DolbyVision();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("l6Metadata", targetDepth))
                {
                    var unmarshaller = DolbyVisionLevel6MetadataUnmarshaller.Instance;
                    unmarshalledObject.L6Metadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("l6Mode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.L6Mode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mapping", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Mapping = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("profile", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Profile = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DolbyVisionUnmarshaller _instance = new DolbyVisionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DolbyVisionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}