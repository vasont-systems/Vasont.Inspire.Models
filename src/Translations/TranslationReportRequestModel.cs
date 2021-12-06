//-------------------------------------------------------------
// <copyright file="TranslationReportRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class contains properties and information to request the system to create a translation report.
    /// </summary>
    public class TranslationReportRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationReportRequestModel" /> class.
        /// </summary>
        public TranslationReportRequestModel()
        {
            this.SendNotification = true;
            this.WorkerCacheLifeTimeoutMinutes = 14200;
        }

        /// <summary>
        /// Gets or sets process identity.
        /// </summary>
        public Guid ProcessId { get; set; }

        /// <summary>
        /// Gets or sets a list of translation identities to create a report for.
        /// </summary>
        public List<long> TranslationIds { get; set; } = new List<long>();

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