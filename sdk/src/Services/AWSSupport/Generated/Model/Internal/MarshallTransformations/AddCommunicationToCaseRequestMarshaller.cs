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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSSupport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddCommunicationToCase Request Marshaller
    /// </summary>       
    public class AddCommunicationToCaseRequestMarshaller : IMarshaller<IRequest, AddCommunicationToCaseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddCommunicationToCaseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AddCommunicationToCaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AWSSupport");
            string target = "AWSSupport_20130415.AddCommunicationToCase";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-04-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttachmentSetId())
                {
                    context.Writer.WritePropertyName("attachmentSetId");
                    context.Writer.Write(publicRequest.AttachmentSetId);
                }

                if(publicRequest.IsSetCaseId())
                {
                    context.Writer.WritePropertyName("caseId");
                    context.Writer.Write(publicRequest.CaseId);
                }

                if(publicRequest.IsSetCcEmailAddresses())
                {
                    context.Writer.WritePropertyName("ccEmailAddresses");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCcEmailAddressesListValue in publicRequest.CcEmailAddresses)
                    {
                            context.Writer.Write(publicRequestCcEmailAddressesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCommunicationBody())
                {
                    context.Writer.WritePropertyName("communicationBody");
                    context.Writer.Write(publicRequest.CommunicationBody);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static AddCommunicationToCaseRequestMarshaller _instance = new AddCommunicationToCaseRequestMarshaller();        

        internal static AddCommunicationToCaseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddCommunicationToCaseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}