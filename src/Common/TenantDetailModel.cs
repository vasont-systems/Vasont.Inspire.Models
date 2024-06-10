//-----------------------------------------------------------------------
// <copyright file="TenantDetailModel.cs" company="GlobalLink Vasont">
//     Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
// <author>Rob Kennedy</author>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    using System;
    using Vasont.IdentityServer.Backchannel.Models;

    /// <summary>
    /// This class represents the basic tenant information needed for the web application.
    /// </summary>
    [Obsolete("Use local DTO", true)]
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
        /// Gets or sets a value indicating whether to filter translation submissions or not.
        /// </summary>
        public bool TranslationFilteringEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to lock english sources a translation submission.
        /// </summary>
        public bool TranslationLockSourceDisabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable Oxygen Web Author within the application.
        /// </summary>
        public bool OxygenWebEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Custom Oxygen Web Author should be enabled within the application.
        /// </summary>
        public bool OxygenWebCustom { get; set; }

        /// <summary>
        /// Gets or sets the number of named seats for oxygen.
        /// </summary>
        public int OxygenNamedSeats { get; set; }

        /// <summary>
        /// Gets or sets the number of concurrent seats for oxygen.
        /// </summary>
        public int OxygenConcurrentSeats { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the application is on a preview system.
        /// </summary>
        public bool PreviewSystem { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Inspire Schema Custom should be enabled within the application.
        /// </summary>
        public bool InspireSchemaCustom { get; set; }

        /// <summary>
        /// Gets or sets the copyright of the tenant application.
        /// </summary>
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the version of the tenant application.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether electronic signature is required or not.
        /// </summary>
        public bool ElectronicSignatureRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to translate first to English.
        /// </summary>
        public bool PivotToEnglishEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to translate first to English en-GB.
        /// </summary>
        public bool PivotToEnglishGBEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use thumbnails for image display.
        /// </summary>
        public bool UseThumbnails { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the tenant has an Expert.ai integration available.
        /// </summary>
        public bool HasExpertAi { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether automatic ids is enabled.
        /// </summary>
        public bool AutomaticIds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether force delete is allowed.
        /// </summary>
        public bool ForceDeleteAllowed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether review comment only is enabled.
        /// </summary>
        public bool ReviewCommentOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether translation approved only is enabled.
        /// </summary>
        public bool TranslationApprovedOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether component approved should be locked.
        /// </summary>
        public bool LockForApprove { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to warn user about changes to referenced content.
        /// </summary>
        public bool SubmitConfirmation { get; set; }
    }
}