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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyBackend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyBackend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateBackendAuthOAuthConfig Object
    /// </summary>  
    public class CreateBackendAuthOAuthConfigUnmarshaller : IUnmarshaller<CreateBackendAuthOAuthConfig, XmlUnmarshallerContext>, IUnmarshaller<CreateBackendAuthOAuthConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CreateBackendAuthOAuthConfig IUnmarshaller<CreateBackendAuthOAuthConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CreateBackendAuthOAuthConfig Unmarshall(JsonUnmarshallerContext context)
        {
            CreateBackendAuthOAuthConfig unmarshalledObject = new CreateBackendAuthOAuthConfig();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("domainPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("oAuthGrantType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OAuthGrantType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("oAuthScopes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.OAuthScopes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("redirectSignInURIs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RedirectSignInURIs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("redirectSignOutURIs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RedirectSignOutURIs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("socialProviderSettings", targetDepth))
                {
                    var unmarshaller = SocialProviderSettingsUnmarshaller.Instance;
                    unmarshalledObject.SocialProviderSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CreateBackendAuthOAuthConfigUnmarshaller _instance = new CreateBackendAuthOAuthConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBackendAuthOAuthConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}