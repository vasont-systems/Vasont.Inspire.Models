﻿//-------------------------------------------------------------
// <copyright file="ValidateCompletenessRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains properties and information to request the system to start an auto repair process.
    /// </summary>
    public class ValidateCompletenessRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateCompletenessRequestModel" /> class.
        /// </summary>
        public ValidateCompletenessRequestModel()
        {
            this.ExportId = 1;
            this.ComponentIds = new List<long>();
            this.SendNotification = true;
            this.WorkerCacheLifeTimeoutMinutes = 14200;
        }

        /// <summary>
        /// Gets or sets process identity.
        /// </summary>
        public Guid ProcessId { get; set; }

        /// <summary>
        /// Gets or sets process identity.
        /// </summary>
        public long ExportId { get; set; }

        /// <summary>
        /// Gets or sets a list of component identities to process.
        /// </summary>
        public List<long> ComponentIds { get; set; }

        /// <summary>
        /// Gets or sets a list of source component names to process.
        /// </summary>
        public List<string> SourceComponentNames { get; set; }

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