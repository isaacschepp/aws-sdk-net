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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MultiplexProgram Object
    /// </summary>  
    public class MultiplexProgramUnmarshaller : IUnmarshaller<MultiplexProgram, XmlUnmarshallerContext>, IUnmarshaller<MultiplexProgram, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MultiplexProgram IUnmarshaller<MultiplexProgram, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MultiplexProgram Unmarshall(JsonUnmarshallerContext context)
        {
            MultiplexProgram unmarshalledObject = new MultiplexProgram();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("channelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("multiplexProgramSettings", targetDepth))
                {
                    var unmarshaller = MultiplexProgramSettingsUnmarshaller.Instance;
                    unmarshalledObject.MultiplexProgramSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("packetIdentifiersMap", targetDepth))
                {
                    var unmarshaller = MultiplexProgramPacketIdentifiersMapUnmarshaller.Instance;
                    unmarshalledObject.PacketIdentifiersMap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pipelineDetails", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MultiplexProgramPipelineDetail, MultiplexProgramPipelineDetailUnmarshaller>(MultiplexProgramPipelineDetailUnmarshaller.Instance);
                    unmarshalledObject.PipelineDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("programName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProgramName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MultiplexProgramUnmarshaller _instance = new MultiplexProgramUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MultiplexProgramUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}