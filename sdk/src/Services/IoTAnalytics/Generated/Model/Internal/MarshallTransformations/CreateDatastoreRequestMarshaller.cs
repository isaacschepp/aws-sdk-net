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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDatastore Request Marshaller
    /// </summary>       
    public class CreateDatastoreRequestMarshaller : IMarshaller<IRequest, CreateDatastoreRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDatastoreRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDatastoreRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTAnalytics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/datastores";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDatastoreName())
                {
                    context.Writer.WritePropertyName("datastoreName");
                    context.Writer.Write(publicRequest.DatastoreName);
                }

                if(publicRequest.IsSetDatastorePartitions())
                {
                    context.Writer.WritePropertyName("datastorePartitions");
                    context.Writer.WriteObjectStart();

                    var marshaller = DatastorePartitionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DatastorePartitions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDatastoreStorage())
                {
                    context.Writer.WritePropertyName("datastoreStorage");
                    context.Writer.WriteObjectStart();

                    var marshaller = DatastoreStorageMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DatastoreStorage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFileFormatConfiguration())
                {
                    context.Writer.WritePropertyName("fileFormatConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = FileFormatConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FileFormatConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRetentionPeriod())
                {
                    context.Writer.WritePropertyName("retentionPeriod");
                    context.Writer.WriteObjectStart();

                    var marshaller = RetentionPeriodMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RetentionPeriod, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDatastoreRequestMarshaller _instance = new CreateDatastoreRequestMarshaller();        

        internal static CreateDatastoreRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDatastoreRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}