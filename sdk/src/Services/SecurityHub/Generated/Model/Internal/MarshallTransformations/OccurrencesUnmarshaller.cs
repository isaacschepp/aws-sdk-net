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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Occurrences Object
    /// </summary>  
    public class OccurrencesUnmarshaller : IUnmarshaller<Occurrences, XmlUnmarshallerContext>, IUnmarshaller<Occurrences, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Occurrences IUnmarshaller<Occurrences, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Occurrences Unmarshall(JsonUnmarshallerContext context)
        {
            Occurrences unmarshalledObject = new Occurrences();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Cells", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Cell, CellUnmarshaller>(CellUnmarshaller.Instance);
                    unmarshalledObject.Cells = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LineRanges", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Range, RangeUnmarshaller>(RangeUnmarshaller.Instance);
                    unmarshalledObject.LineRanges = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OffsetRanges", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Range, RangeUnmarshaller>(RangeUnmarshaller.Instance);
                    unmarshalledObject.OffsetRanges = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Pages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Page, PageUnmarshaller>(PageUnmarshaller.Instance);
                    unmarshalledObject.Pages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Records", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Record, RecordUnmarshaller>(RecordUnmarshaller.Instance);
                    unmarshalledObject.Records = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OccurrencesUnmarshaller _instance = new OccurrencesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OccurrencesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}