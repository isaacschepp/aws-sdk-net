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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFRegional.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WAFRegional.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SizeConstraintSet Object
    /// </summary>  
    public class SizeConstraintSetUnmarshaller : IUnmarshaller<SizeConstraintSet, XmlUnmarshallerContext>, IUnmarshaller<SizeConstraintSet, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SizeConstraintSet IUnmarshaller<SizeConstraintSet, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SizeConstraintSet Unmarshall(JsonUnmarshallerContext context)
        {
            SizeConstraintSet unmarshalledObject = new SizeConstraintSet();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SizeConstraints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SizeConstraint, SizeConstraintUnmarshaller>(SizeConstraintUnmarshaller.Instance);
                    unmarshalledObject.SizeConstraints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SizeConstraintSetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SizeConstraintSetId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SizeConstraintSetUnmarshaller _instance = new SizeConstraintSetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SizeConstraintSetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}