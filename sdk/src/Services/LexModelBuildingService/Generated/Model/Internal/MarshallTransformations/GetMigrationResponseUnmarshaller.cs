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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelBuildingService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetMigration operation
    /// </summary>  
    public class GetMigrationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetMigrationResponse response = new GetMigrationResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("alerts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MigrationAlert, MigrationAlertUnmarshaller>(MigrationAlertUnmarshaller.Instance);
                    response.Alerts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("migrationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MigrationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("migrationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MigrationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("migrationStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MigrationStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("migrationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.MigrationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("v1BotLocale", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.V1BotLocale = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("v1BotName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.V1BotName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("v1BotVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.V1BotVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("v2BotId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.V2BotId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("v2BotRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.V2BotRole = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                {
                    return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
                {
                    return InternalFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
                {
                    return LimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                {
                    return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonLexModelBuildingServiceException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetMigrationResponseUnmarshaller _instance = new GetMigrationResponseUnmarshaller();        

        internal static GetMigrationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMigrationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}