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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
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
namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateContactFromAddressBook operation.
    /// Disassociates a contact from a given address book.
    /// </summary>
    public partial class DisassociateContactFromAddressBookRequest : AmazonAlexaForBusinessRequest
    {
        private string _addressBookArn;
        private string _contactArn;

        /// <summary>
        /// Gets and sets the property AddressBookArn. 
        /// <para>
        /// The ARN of the address from which to disassociate the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AddressBookArn
        {
            get { return this._addressBookArn; }
            set { this._addressBookArn = value; }
        }

        // Check to see if AddressBookArn property is set
        internal bool IsSetAddressBookArn()
        {
            return this._addressBookArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContactArn. 
        /// <para>
        /// The ARN of the contact to disassociate from an address book.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContactArn
        {
            get { return this._contactArn; }
            set { this._contactArn = value; }
        }

        // Check to see if ContactArn property is set
        internal bool IsSetContactArn()
        {
            return this._contactArn != null;
        }

    }
}