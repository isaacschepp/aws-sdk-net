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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SnowDeviceManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SnowDeviceManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceBlockDeviceMapping Object
    /// </summary>  
    public class InstanceBlockDeviceMappingUnmarshaller : IUnmarshaller<InstanceBlockDeviceMapping, XmlUnmarshallerContext>, IUnmarshaller<InstanceBlockDeviceMapping, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InstanceBlockDeviceMapping IUnmarshaller<InstanceBlockDeviceMapping, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InstanceBlockDeviceMapping Unmarshall(JsonUnmarshallerContext context)
        {
            InstanceBlockDeviceMapping unmarshalledObject = new InstanceBlockDeviceMapping();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("deviceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ebs", targetDepth))
                {
                    var unmarshaller = EbsInstanceBlockDeviceUnmarshaller.Instance;
                    unmarshalledObject.Ebs = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InstanceBlockDeviceMappingUnmarshaller _instance = new InstanceBlockDeviceMappingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceBlockDeviceMappingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}