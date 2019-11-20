﻿//-----------------------------------------------------------------------
// <copyright file="TenantDetailModel.cs" company="Vasont Systems">
//     Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
// <author>Rob Kennedy</author>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    using Vasont.IdentityServer.Backchannel.Models;

    /// <summary>
    /// This class represents the basic tenant information needed for the web application.
    /// </summary>
    public class TenantDetailModel
    {
        /// <summary>
        /// Gets or sets the domain key.
        /// </summary>
        public string DomainKey { get; set; }

        /// <summary>
        /// Gets or sets the tenant name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the tenant account type.
        /// </summary>
        public ApplicationSubscriptionLevel SubscriptionLevel { get; set; }

        /// <summary>
        /// Gets or sets the support information about the Tenant.
        /// </summary>
        public string SupportInfo { get; set; }

        /// <summary>
        /// Gets or sets the support contact e-mail address for the Tenant.
        /// </summary>
        public string SupportEmail { get; set; }

        /// <summary>
        /// Gets or sets the default language to use for the tenant application.
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// Gets or sets the server's session timeout in minutes.
        /// </summary>
        public int SessionTimeout { get; set; }

        /// <summary>
        /// Gets or sets the copyright of the tenant application.
        /// </summary>
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the version of the tenant application.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to filter translation submissions or not.
        /// </summary>
        public bool TranslationFilteringEnabled { get; set; }
    }
}