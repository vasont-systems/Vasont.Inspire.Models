//-------------------------------------------------------------
// <copyright file="ReviewReportRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class contains properties and information to request the system to create a review report.
    /// </summary>
    public class ReviewReportRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewReportRequestModel" /> class.
        /// </summary>
        public ReviewReportRequestModel()
        {
            this.SendNotification = true;
            this.WorkerCacheLifeTimeoutMinutes = 14200;
        }

        /// <summary>
        /// Gets or sets process identity.
        /// </summary>
        public Guid ProcessId { get; set; }

        /// <summary>
        /// Gets or sets a list of review identities to create a report for.
        /// </summary>
        public List<long> ReviewIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets a list of review identities to create a report for.
        /// </summary>
        public List<MinimalUserModel> Recipients { get; set; } = new List<MinimalUserModel>();

        /// <summary>
        /// Gets or sets a list of additional emails separated with semi-colon.
        /// </summary>
        public string AdditionalEmails { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether reviewer details should be included in report.
        /// </summary>
        public bool IncludeReviewerDetails { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether discussions should be included in report.
        /// </summary>
        public bool IncludeDiscussions { get; set; } = true;

        /// <summary>
        /// Gets or sets a value with an additional comment for the report.
        /// </summary>
        public string AdditionalComment { get; set; }

        /// <summary>
        /// Gets or sets a list of review participants that review should be filtered for.
        /// </summary>
        public List<MinimalUserModel> FilterUsers { get; set; } = new List<MinimalUserModel>();

        /// <summary>
        /// Gets or sets a value indicating whether notifications are sent after process has completed.
        /// </summary>
        public bool SendNotification { get; set; }

        /// <summary>
        /// Gets or sets the number of minutes the worker timeout will last.
        /// </summary>
        public int WorkerCacheLifeTimeoutMinutes { get; set; }
    }
}