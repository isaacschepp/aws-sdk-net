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
    /// Response Unmarshaller for MsSmoothGroupSettings Object
    /// </summary>  
    public class MsSmoothGroupSettingsUnmarshaller : IUnmarshaller<MsSmoothGroupSettings, XmlUnmarshallerContext>, IUnmarshaller<MsSmoothGroupSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MsSmoothGroupSettings IUnmarshaller<MsSmoothGroupSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MsSmoothGroupSettings Unmarshall(JsonUnmarshallerContext context)
        {
            MsSmoothGroupSettings unmarshalledObject = new MsSmoothGroupSettings();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("additionalManifests", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MsSmoothAdditionalManifest, MsSmoothAdditionalManifestUnmarshaller>(MsSmoothAdditionalManifestUnmarshaller.Instance);
                    unmarshalledObject.AdditionalManifests = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioDeduplication", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioDeduplication = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destination", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Destination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destinationSettings", targetDepth))
                {
                    var unmarshaller = DestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.DestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryption", targetDepth))
                {
                    var unmarshaller = MsSmoothEncryptionSettingsUnmarshaller.Instance;
                    unmarshalledObject.Encryption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fragmentLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FragmentLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fragmentLengthControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FragmentLengthControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("manifestEncoding", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManifestEncoding = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MsSmoothGroupSettingsUnmarshaller _instance = new MsSmoothGroupSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MsSmoothGroupSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}