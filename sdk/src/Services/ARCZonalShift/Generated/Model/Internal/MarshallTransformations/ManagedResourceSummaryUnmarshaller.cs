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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCZonalShift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ARCZonalShift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ManagedResourceSummary Object
    /// </summary>  
    public class ManagedResourceSummaryUnmarshaller : IUnmarshaller<ManagedResourceSummary, XmlUnmarshallerContext>, IUnmarshaller<ManagedResourceSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ManagedResourceSummary IUnmarshaller<ManagedResourceSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ManagedResourceSummary Unmarshall(JsonUnmarshallerContext context)
        {
            ManagedResourceSummary unmarshalledObject = new ManagedResourceSummary();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("appliedWeights", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, float, StringUnmarshaller, FloatUnmarshaller>(StringUnmarshaller.Instance, FloatUnmarshaller.Instance);
                    unmarshalledObject.AppliedWeights = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("autoshifts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AutoshiftInResource, AutoshiftInResourceUnmarshaller>(AutoshiftInResourceUnmarshaller.Instance);
                    unmarshalledObject.Autoshifts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availabilityZones", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AvailabilityZones = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("practiceRunStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PracticeRunStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zonalAutoshiftStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ZonalAutoshiftStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zonalShifts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ZonalShiftInResource, ZonalShiftInResourceUnmarshaller>(ZonalShiftInResourceUnmarshaller.Instance);
                    unmarshalledObject.ZonalShifts = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ManagedResourceSummaryUnmarshaller _instance = new ManagedResourceSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ManagedResourceSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}