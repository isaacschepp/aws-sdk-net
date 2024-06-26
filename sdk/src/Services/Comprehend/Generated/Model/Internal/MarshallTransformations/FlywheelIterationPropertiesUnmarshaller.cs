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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Comprehend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FlywheelIterationProperties Object
    /// </summary>  
    public class FlywheelIterationPropertiesUnmarshaller : IUnmarshaller<FlywheelIterationProperties, XmlUnmarshallerContext>, IUnmarshaller<FlywheelIterationProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FlywheelIterationProperties IUnmarshaller<FlywheelIterationProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public FlywheelIterationProperties Unmarshall(JsonUnmarshallerContext context)
        {
            FlywheelIterationProperties unmarshalledObject = new FlywheelIterationProperties();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluatedModelArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluatedModelArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluatedModelMetrics", targetDepth))
                {
                    var unmarshaller = FlywheelModelEvaluationMetricsUnmarshaller.Instance;
                    unmarshalledObject.EvaluatedModelMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationManifestS3Prefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluationManifestS3Prefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FlywheelArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FlywheelArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FlywheelIterationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FlywheelIterationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Message", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Message = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainedModelArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainedModelArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainedModelMetrics", targetDepth))
                {
                    var unmarshaller = FlywheelModelEvaluationMetricsUnmarshaller.Instance;
                    unmarshalledObject.TrainedModelMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FlywheelIterationPropertiesUnmarshaller _instance = new FlywheelIterationPropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FlywheelIterationPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}