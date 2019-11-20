//-----------------------------------------------------------------------
// <copyright file="EventLoggingFilter.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Logging
{
    using System;
    using Vasont.Inspire.Core.Extensions;

    /// <summary>
    /// This class contains all the filter properties used to modify an event log query
    /// </summary>
    public sealed class EventLoggingFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventLoggingFilter"/> class
        /// </summary>
        public EventLoggingFilter()
        {
            this.StartDate = DateTime.MinValue;
            this.EndDate = DateTime.Now;
            this.Direction = SortDirection.Asc;
            this.MaximumRows = 100;
            this.LevelsFilter = EventLogLevel.All;
        }

        /// <summary>
        /// Gets or sets the filter start date
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the filter end date
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the filter order by column name
        /// </summary>
        public string OrderByName { get; set; }

        /// <summary>
        /// Gets or sets the order by sort direction
        /// </summary>
        public SortDirection Direction { get; set; }

        /// <summary>
        /// Gets or sets the maximum rows to return
        /// </summary>
        public int MaximumRows { get; set; }

        /// <summary>
        /// Gets or sets the logger name filter
        /// </summary>
        public string LoggerName { get; set; }

        /// <summary>
        /// Gets or sets the event log level filter
        /// </summary>
        public EventLogLevel LevelsFilter { get; set; }
    }
}