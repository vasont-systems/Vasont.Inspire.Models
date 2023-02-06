//-------------------------------------------------------------
// <copyright file="EventLogQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Logging
{
    using System;
    using Common;

    /// <summary>
    ///  This class contains parameters passed to the query for filtering.
    /// </summary>
    public class EventLogQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        ///  Gets or sets the search text of the paged query.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        ///  Gets or sets the start date of the paged query.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        ///  Gets or sets the end date of the paged query.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the log level of the event log lookup.
        /// </summary>
        public string Level { get; set; }
    }
}