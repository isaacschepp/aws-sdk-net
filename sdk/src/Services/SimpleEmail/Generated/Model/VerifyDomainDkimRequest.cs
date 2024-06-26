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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the VerifyDomainDkim operation.
    /// Returns a set of DKIM tokens for a domain identity.
    /// 
    ///  <important> 
    /// <para>
    /// When you execute the <c>VerifyDomainDkim</c> operation, the domain that you specify
    /// is added to the list of identities that are associated with your account. This is
    /// true even if you haven't already associated the domain with your account by using
    /// the <c>VerifyDomainIdentity</c> operation. However, you can't send email from the
    /// domain until you either successfully <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#verify-domain-procedure">verify
    /// it</a> or you successfully <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-authentication-dkim-easy.html">set
    /// up DKIM for it</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// You use the tokens that are generated by this operation to create CNAME records. When
    /// Amazon SES detects that you've added these records to the DNS configuration for a
    /// domain, you can start sending email from that domain. You can start sending email
    /// even if you haven't added the TXT record provided by the VerifyDomainIdentity operation
    /// to the DNS configuration for your domain. All email that you send from the domain
    /// is authenticated using DKIM.
    /// </para>
    ///  
    /// <para>
    /// To create the CNAME records for DKIM authentication, use the following values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Name</b>: <i>token</i>._domainkey.<i>example.com</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Type</b>: CNAME
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Value</b>: <i>token</i>.dkim.amazonses.com
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In the preceding example, replace <i>token</i> with one of the tokens that are generated
    /// when you execute this operation. Replace <i>example.com</i> with your domain. Repeat
    /// this process for each token that's generated by this operation.
    /// </para>
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class VerifyDomainDkimRequest : AmazonSimpleEmailServiceRequest
    {
        private string _domain;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain to be verified for Easy DKIM signing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

    }
}