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
    /// Response Unmarshaller for ProtectiveEquipmentPerson Object
    /// </summary>  
    public class ProtectiveEquipmentPersonUnmarshaller : IUnmarshaller<ProtectiveEquipmentPerson, XmlUnmarshallerContext>, IUnmarshaller<ProtectiveEquipmentPerson, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProtectiveEquipmentPerson IUnmarshaller<ProtectiveEquipmentPerson, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ProtectiveEquipmentPerson Unmarshall(JsonUnmarshallerContext context)
        {
            ProtectiveEquipmentPerson unmarshalledObject = new ProtectiveEquipmentPerson();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BodyParts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ProtectiveEquipmentBodyPart, ProtectiveEquipmentBodyPartUnmarshaller>(ProtectiveEquipmentBodyPartUnmarshaller.Instance);
                    unmarshalledObject.BodyParts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BoundingBox", targetDepth))
                {
                    var unmarshaller = BoundingBoxUnmarshaller.Instance;
                    unmarshalledObject.BoundingBox = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Confidence", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.Confidence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ProtectiveEquipmentPersonUnmarshaller _instance = new ProtectiveEquipmentPersonUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProtectiveEquipmentPersonUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}