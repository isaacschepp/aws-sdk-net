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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the StopCrawlerSchedule operation.
    /// Sets the schedule state of the specified crawler to <c>NOT_SCHEDULED</c>, but does
    /// not stop the crawler if it is already running.
    /// </summary>
    public partial class StopCrawlerScheduleRequest : AmazonGlueRequest
    {
        private string _crawlerName;

        /// <summary>
        /// Gets and sets the property CrawlerName. 
        /// <para>
        /// Name of the crawler whose schedule state to set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string CrawlerName
        {
            get { return this._crawlerName; }
            set { this._crawlerName = value; }
        }

        // Check to see if CrawlerName property is set
        internal bool IsSetCrawlerName()
        {
            return this._crawlerName != null;
        }

    }
}