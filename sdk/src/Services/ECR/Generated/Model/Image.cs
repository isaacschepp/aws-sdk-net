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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// An object representing an Amazon ECR image.
    /// </summary>
    public partial class Image
    {
        private ImageIdentifier _imageId;
        private string _imageManifest;
        private string _imageManifestMediaType;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// An object containing the image tag and image digest associated with an image.
        /// </para>
        /// </summary>
        public ImageIdentifier ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageManifest. 
        /// <para>
        /// The image manifest associated with the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4194304)]
        public string ImageManifest
        {
            get { return this._imageManifest; }
            set { this._imageManifest = value; }
        }

        // Check to see if ImageManifest property is set
        internal bool IsSetImageManifest()
        {
            return this._imageManifest != null;
        }

        /// <summary>
        /// Gets and sets the property ImageManifestMediaType. 
        /// <para>
        /// The manifest media type of the image.
        /// </para>
        /// </summary>
        public string ImageManifestMediaType
        {
            get { return this._imageManifestMediaType; }
            set { this._imageManifestMediaType = value; }
        }

        // Check to see if ImageManifestMediaType property is set
        internal bool IsSetImageManifestMediaType()
        {
            return this._imageManifestMediaType != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry containing the image.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository associated with the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=256)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}