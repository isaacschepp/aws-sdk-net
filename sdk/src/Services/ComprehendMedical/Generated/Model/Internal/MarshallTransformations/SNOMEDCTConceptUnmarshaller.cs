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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComprehendMedical.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ComprehendMedical.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SNOMEDCTConcept Object
    /// </summary>  
    public class SNOMEDCTConceptUnmarshaller : IUnmarshaller<SNOMEDCTConcept, XmlUnmarshallerContext>, IUnmarshaller<SNOMEDCTConcept, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SNOMEDCTConcept IUnmarshaller<SNOMEDCTConcept, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SNOMEDCTConcept Unmarshall(JsonUnmarshallerContext context)
        {
            SNOMEDCTConcept unmarshalledObject = new SNOMEDCTConcept();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Code", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Code = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Score", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.Score = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SNOMEDCTConceptUnmarshaller _instance = new SNOMEDCTConceptUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SNOMEDCTConceptUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}