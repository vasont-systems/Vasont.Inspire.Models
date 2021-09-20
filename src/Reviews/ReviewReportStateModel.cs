//-------------------------------------------------------------
// <copyright file="ReviewReportStateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains the state for review report request worker within the application.
    /// </summary>
    public class ReviewReportStateModel
    {
        /// <summary>
        /// Gets or sets the process identity.
        /// </summary>
        public Guid ProcessId { get; set; }

        /// <summary>
        /// Gets or sets a list of reviews to process.
        /// </summary>
        public List<long> ReviewIds { get; set; } = new List<long>();
    }
}
