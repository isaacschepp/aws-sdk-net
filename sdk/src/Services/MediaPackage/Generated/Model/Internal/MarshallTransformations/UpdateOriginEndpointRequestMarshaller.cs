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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackage.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackage.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateOriginEndpoint Request Marshaller
    /// </summary>       
    public class UpdateOriginEndpointRequestMarshaller : IMarshaller<IRequest, UpdateOriginEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateOriginEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateOriginEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaPackage");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-12";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetId())
                throw new AmazonMediaPackageException("Request object does not have required field Id set");
            request.AddPathResource("{id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/origin_endpoints/{id}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthorization())
                {
                    context.Writer.WritePropertyName("authorization");
                    context.Writer.WriteObjectStart();

                    var marshaller = AuthorizationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Authorization, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCmafPackage())
                {
                    context.Writer.WritePropertyName("cmafPackage");
                    context.Writer.WriteObjectStart();

                    var marshaller = CmafPackageCreateOrUpdateParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CmafPackage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDashPackage())
                {
                    context.Writer.WritePropertyName("dashPackage");
                    context.Writer.WriteObjectStart();

                    var marshaller = DashPackageMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DashPackage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetHlsPackage())
                {
                    context.Writer.WritePropertyName("hlsPackage");
                    context.Writer.WriteObjectStart();

                    var marshaller = HlsPackageMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HlsPackage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetManifestName())
                {
                    context.Writer.WritePropertyName("manifestName");
                    context.Writer.Write(publicRequest.ManifestName);
                }

                if(publicRequest.IsSetMssPackage())
                {
                    context.Writer.WritePropertyName("mssPackage");
                    context.Writer.WriteObjectStart();

                    var marshaller = MssPackageMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MssPackage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOrigination())
                {
                    context.Writer.WritePropertyName("origination");
                    context.Writer.Write(publicRequest.Origination);
                }

                if(publicRequest.IsSetStartoverWindowSeconds())
                {
                    context.Writer.WritePropertyName("startoverWindowSeconds");
                    context.Writer.Write(publicRequest.StartoverWindowSeconds);
                }

                if(publicRequest.IsSetTimeDelaySeconds())
                {
                    context.Writer.WritePropertyName("timeDelaySeconds");
                    context.Writer.Write(publicRequest.TimeDelaySeconds);
                }

                if(publicRequest.IsSetWhitelist())
                {
                    context.Writer.WritePropertyName("whitelist");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWhitelistListValue in publicRequest.Whitelist)
                    {
                            context.Writer.Write(publicRequestWhitelistListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateOriginEndpointRequestMarshaller _instance = new UpdateOriginEndpointRequestMarshaller();        

        internal static UpdateOriginEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateOriginEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}