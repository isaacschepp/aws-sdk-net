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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkDocs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResponseItem Object
    /// </summary>  
    public class ResponseItemUnmarshaller : IUnmarshaller<ResponseItem, XmlUnmarshallerContext>, IUnmarshaller<ResponseItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResponseItem IUnmarshaller<ResponseItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ResponseItem Unmarshall(JsonUnmarshallerContext context)
        {
            ResponseItem unmarshalledObject = new ResponseItem();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CommentMetadata", targetDepth))
                {
                    var unmarshaller = CommentMetadataUnmarshaller.Instance;
                    unmarshalledObject.CommentMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentMetadata", targetDepth))
                {
                    var unmarshaller = DocumentMetadataUnmarshaller.Instance;
                    unmarshalledObject.DocumentMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentVersionMetadata", targetDepth))
                {
                    var unmarshaller = DocumentVersionMetadataUnmarshaller.Instance;
                    unmarshalledObject.DocumentVersionMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FolderMetadata", targetDepth))
                {
                    var unmarshaller = FolderMetadataUnmarshaller.Instance;
                    unmarshalledObject.FolderMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WebUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WebUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ResponseItemUnmarshaller _instance = new ResponseItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResponseItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}