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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Honeycode.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Honeycode.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTables Request Marshaller
    /// </summary>       
    public class ListTablesRequestMarshaller : IMarshaller<IRequest, ListTablesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTablesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListTablesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Honeycode");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetWorkbookId())
                throw new AmazonHoneycodeException("Request object does not have required field WorkbookId set");
            request.AddPathResource("{workbookId}", StringUtils.FromString(publicRequest.WorkbookId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/workbooks/{workbookId}/tables";
            request.UseQueryString = true;

            return request;
        }
        private static ListTablesRequestMarshaller _instance = new ListTablesRequestMarshaller();        

        internal static ListTablesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListTablesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}