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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// The summary information for the data catalog, which includes its name and type.
    /// </summary>
    public partial class DataCatalogSummary
    {
        private string _catalogName;
        private DataCatalogType _type;

        /// <summary>
        /// Gets and sets the property CatalogName. 
        /// <para>
        /// The name of the data catalog. The catalog name is unique for the Amazon Web Services
        /// account and can use a maximum of 127 alphanumeric, underscore, at sign, or hyphen
        /// characters. The remainder of the length constraint of 256 is reserved for use by Athena.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string CatalogName
        {
            get { return this._catalogName; }
            set { this._catalogName = value; }
        }

        // Check to see if CatalogName property is set
        internal bool IsSetCatalogName()
        {
            return this._catalogName != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data catalog type.
        /// </para>
        /// </summary>
        public DataCatalogType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}