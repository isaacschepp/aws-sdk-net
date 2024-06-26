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
    /// InitiateDocumentVersionUpload Request Marshaller
    /// </summary>       
    public class InitiateDocumentVersionUploadRequestMarshaller : IMarshaller<IRequest, InitiateDocumentVersionUploadRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InitiateDocumentVersionUploadRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InitiateDocumentVersionUploadRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/api/v1/documents";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContentCreatedTimestamp())
                {
                    context.Writer.WritePropertyName("ContentCreatedTimestamp");
                    context.Writer.Write(publicRequest.ContentCreatedTimestamp);
                }

                if(publicRequest.IsSetContentModifiedTimestamp())
                {
                    context.Writer.WritePropertyName("ContentModifiedTimestamp");
                    context.Writer.Write(publicRequest.ContentModifiedTimestamp);
                }

                if(publicRequest.IsSetContentType())
                {
                    context.Writer.WritePropertyName("ContentType");
                    context.Writer.Write(publicRequest.ContentType);
                }

                if(publicRequest.IsSetDocumentSizeInBytes())
                {
                    context.Writer.WritePropertyName("DocumentSizeInBytes");
                    context.Writer.Write(publicRequest.DocumentSizeInBytes);
                }

                if(publicRequest.IsSetId())
                {
                    context.Writer.WritePropertyName("Id");
                    context.Writer.Write(publicRequest.Id);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetParentFolderId())
                {
                    context.Writer.WritePropertyName("ParentFolderId");
                    context.Writer.Write(publicRequest.ParentFolderId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetAuthenticationToken()) 
            {
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;
            }

            return request;
        }
        private static InitiateDocumentVersionUploadRequestMarshaller _instance = new InitiateDocumentVersionUploadRequestMarshaller();        

        internal static InitiateDocumentVersionUploadRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InitiateDocumentVersionUploadRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}