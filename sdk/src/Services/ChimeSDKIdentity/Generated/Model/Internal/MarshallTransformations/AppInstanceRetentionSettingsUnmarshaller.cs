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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKIdentity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AppInstanceRetentionSettings Object
    /// </summary>  
    public class AppInstanceRetentionSettingsUnmarshaller : IUnmarshaller<AppInstanceRetentionSettings, XmlUnmarshallerContext>, IUnmarshaller<AppInstanceRetentionSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AppInstanceRetentionSettings IUnmarshaller<AppInstanceRetentionSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AppInstanceRetentionSettings Unmarshall(JsonUnmarshallerContext context)
        {
            AppInstanceRetentionSettings unmarshalledObject = new AppInstanceRetentionSettings();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ChannelRetentionSettings", targetDepth))
                {
                    var unmarshaller = ChannelRetentionSettingsUnmarshaller.Instance;
                    unmarshalledObject.ChannelRetentionSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AppInstanceRetentionSettingsUnmarshaller _instance = new AppInstanceRetentionSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AppInstanceRetentionSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}