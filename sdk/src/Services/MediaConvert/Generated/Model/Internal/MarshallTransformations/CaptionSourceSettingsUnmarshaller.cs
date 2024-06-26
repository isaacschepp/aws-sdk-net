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
    /// Response Unmarshaller for CaptionSourceSettings Object
    /// </summary>  
    public class CaptionSourceSettingsUnmarshaller : IUnmarshaller<CaptionSourceSettings, XmlUnmarshallerContext>, IUnmarshaller<CaptionSourceSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CaptionSourceSettings IUnmarshaller<CaptionSourceSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CaptionSourceSettings Unmarshall(JsonUnmarshallerContext context)
        {
            CaptionSourceSettings unmarshalledObject = new CaptionSourceSettings();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ancillarySourceSettings", targetDepth))
                {
                    var unmarshaller = AncillarySourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.AncillarySourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dvbSubSourceSettings", targetDepth))
                {
                    var unmarshaller = DvbSubSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbSubSourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("embeddedSourceSettings", targetDepth))
                {
                    var unmarshaller = EmbeddedSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.EmbeddedSourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileSourceSettings", targetDepth))
                {
                    var unmarshaller = FileSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.FileSourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("teletextSourceSettings", targetDepth))
                {
                    var unmarshaller = TeletextSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.TeletextSourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("trackSourceSettings", targetDepth))
                {
                    var unmarshaller = TrackSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.TrackSourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("webvttHlsSourceSettings", targetDepth))
                {
                    var unmarshaller = WebvttHlsSourceSettingsUnmarshaller.Instance;
                    unmarshalledObject.WebvttHlsSourceSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CaptionSourceSettingsUnmarshaller _instance = new CaptionSourceSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CaptionSourceSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}