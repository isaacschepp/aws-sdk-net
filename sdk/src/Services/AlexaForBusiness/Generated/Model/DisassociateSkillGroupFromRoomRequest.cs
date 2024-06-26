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
    /// Container for the parameters to the DisassociateSkillGroupFromRoom operation.
    /// Disassociates a skill group from a specified room. This disables all skills in the
    /// skill group on all devices in the room.
    /// </summary>
    public partial class DisassociateSkillGroupFromRoomRequest : AmazonAlexaForBusinessRequest
    {
        private string _roomArn;
        private string _skillGroupArn;

        /// <summary>
        /// Gets and sets the property RoomArn. 
        /// <para>
        /// The ARN of the room from which the skill group is to be disassociated. Required.
        /// </para>
        /// </summary>
        public string RoomArn
        {
            get { return this._roomArn; }
            set { this._roomArn = value; }
        }

        // Check to see if RoomArn property is set
        internal bool IsSetRoomArn()
        {
            return this._roomArn != null;
        }

        /// <summary>
        /// Gets and sets the property SkillGroupArn. 
        /// <para>
        /// The ARN of the skill group to disassociate from a room. Required.
        /// </para>
        /// </summary>
        public string SkillGroupArn
        {
            get { return this._skillGroupArn; }
            set { this._skillGroupArn = value; }
        }

        // Check to see if SkillGroupArn property is set
        internal bool IsSetSkillGroupArn()
        {
            return this._skillGroupArn != null;
        }

    }
}