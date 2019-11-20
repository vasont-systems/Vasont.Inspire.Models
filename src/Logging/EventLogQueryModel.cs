//-------------------------------------------------------------
// <copyright file="EventLogQueryModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
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
    }
}