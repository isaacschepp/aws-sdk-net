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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SavingsPlansPurchaseRecommendationSummary Object
    /// </summary>  
    public class SavingsPlansPurchaseRecommendationSummaryUnmarshaller : IUnmarshaller<SavingsPlansPurchaseRecommendationSummary, XmlUnmarshallerContext>, IUnmarshaller<SavingsPlansPurchaseRecommendationSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SavingsPlansPurchaseRecommendationSummary IUnmarshaller<SavingsPlansPurchaseRecommendationSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SavingsPlansPurchaseRecommendationSummary Unmarshall(JsonUnmarshallerContext context)
        {
            SavingsPlansPurchaseRecommendationSummary unmarshalledObject = new SavingsPlansPurchaseRecommendationSummary();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CurrencyCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentOnDemandSpend", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentOnDemandSpend = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DailyCommitmentToPurchase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DailyCommitmentToPurchase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedMonthlySavingsAmount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedMonthlySavingsAmount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedOnDemandCostWithCurrentCommitment", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedOnDemandCostWithCurrentCommitment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedROI", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedROI = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedSavingsAmount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedSavingsAmount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedSavingsPercentage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedSavingsPercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedTotalCost", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedTotalCost = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HourlyCommitmentToPurchase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HourlyCommitmentToPurchase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalRecommendationCount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TotalRecommendationCount = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SavingsPlansPurchaseRecommendationSummaryUnmarshaller _instance = new SavingsPlansPurchaseRecommendationSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SavingsPlansPurchaseRecommendationSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}