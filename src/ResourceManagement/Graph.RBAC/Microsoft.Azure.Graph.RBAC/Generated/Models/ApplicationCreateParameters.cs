// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Request parameters for create a new application
    /// </summary>
    public partial class ApplicationCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationCreateParameters
        /// class.
        /// </summary>
        public ApplicationCreateParameters() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationCreateParameters
        /// class.
        /// </summary>
        public ApplicationCreateParameters(bool? availableToOtherTenants, string displayName, string homepage, IList<string> identifierUris, IList<string> replyUrls = default(IList<string>), IList<KeyCredential> keyCredentials = default(IList<KeyCredential>), IList<PasswordCredential> passwordCredentials = default(IList<PasswordCredential>))
        {
            AvailableToOtherTenants = availableToOtherTenants;
            DisplayName = displayName;
            Homepage = homepage;
            IdentifierUris = identifierUris;
            ReplyUrls = replyUrls;
            KeyCredentials = keyCredentials;
            PasswordCredentials = passwordCredentials;
        }

        /// <summary>
        /// Indicates if the application will be available to other tenants
        /// </summary>
        [JsonProperty(PropertyName = "availableToOtherTenants")]
        public bool? AvailableToOtherTenants { get; set; }

        /// <summary>
        /// Application display name
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Application homepage
        /// </summary>
        [JsonProperty(PropertyName = "homepage")]
        public string Homepage { get; set; }

        /// <summary>
        /// Application Uris
        /// </summary>
        [JsonProperty(PropertyName = "identifierUris")]
        public IList<string> IdentifierUris { get; set; }

        /// <summary>
        /// Application reply Urls
        /// </summary>
        [JsonProperty(PropertyName = "replyUrls")]
        public IList<string> ReplyUrls { get; set; }

        /// <summary>
        /// Gets or sets the list of KeyCredential objects
        /// </summary>
        [JsonProperty(PropertyName = "keyCredentials")]
        public IList<KeyCredential> KeyCredentials { get; set; }

        /// <summary>
        /// Gets or sets the list of PasswordCredential objects
        /// </summary>
        [JsonProperty(PropertyName = "passwordCredentials")]
        public IList<PasswordCredential> PasswordCredentials { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (AvailableToOtherTenants == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AvailableToOtherTenants");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Homepage == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Homepage");
            }
            if (IdentifierUris == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IdentifierUris");
            }
        }
    }
}