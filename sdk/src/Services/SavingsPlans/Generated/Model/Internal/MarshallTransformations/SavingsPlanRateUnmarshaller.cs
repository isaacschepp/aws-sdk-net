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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SavingsPlans.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SavingsPlans.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SavingsPlanRate Object
    /// </summary>  
    public class SavingsPlanRateUnmarshaller : IUnmarshaller<SavingsPlanRate, XmlUnmarshallerContext>, IUnmarshaller<SavingsPlanRate, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SavingsPlanRate IUnmarshaller<SavingsPlanRate, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SavingsPlanRate Unmarshall(JsonUnmarshallerContext context)
        {
            SavingsPlanRate unmarshalledObject = new SavingsPlanRate();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("currency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Currency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("operation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Operation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("productType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("properties", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SavingsPlanRateProperty, SavingsPlanRatePropertyUnmarshaller>(SavingsPlanRatePropertyUnmarshaller.Instance);
                    unmarshalledObject.Properties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Rate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Unit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("usageType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UsageType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SavingsPlanRateUnmarshaller _instance = new SavingsPlanRateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SavingsPlanRateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}