//-------------------------------------------------------------
// <copyright file="ValidateCompletenessRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Transfers;

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
        public List<long> ComponentIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets a list of source component names to process.
        /// </summary>
        public List<string> SourceComponentNames { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets a value indicating whether notifications are sent after process has completed.
        /// </summary>
        public bool SendNotification { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to error for unapproved component.
        /// </summary>
        public bool ComponentNotApproved { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to error for unsigned components.
        /// </summary>
        public bool ComponentNotSigned { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to error for locked component.
        /// </summary>
        public bool ComponentLocked { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to error for component locked to self.
        /// </summary>
        public bool ComponentLockedBySelf { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to error for component with invalid state.
        /// </summary>
        public bool ComponentInvalidState { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to error for component with invalid XML.
        /// </summary>
        public bool ComponentInvalidXml { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to error for component with invalid processing instructions.
        /// </summary>
        public bool ComponentInvalidPis { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to error for locked translation components.
        /// </summary>
        public bool TargetComponentLocked { get; set; }

        /// <summary>
        /// Gets or sets an optional list of profile filters.
        /// </summary>
        public List<ExportProfileAttributeFilterModel> ProfileFilters { get; set; } = new List<ExportProfileAttributeFilterModel>();

        /// <summary>
        /// Gets or sets the xml content to validate.
        /// </summary>
        public string XmlContent { get; set; }

        /// <summary>
        /// Gets or sets the number of minutes the worker timeout will last.
        /// </summary>
        public int WorkerCacheLifeTimeoutMinutes { get; set; }
    }
}