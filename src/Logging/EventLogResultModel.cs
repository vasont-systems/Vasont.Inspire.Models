//-------------------------------------------------------------
// <copyright file="EventLogResultModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Logging
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of an event log result request.
    /// </summary>
    public class EventLogResultModel
    {
        /// <summary>
        /// Gets or sets the total number of records.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the results of the event log request.
        /// </summary>
        public List<EventLogModel> Results { get; set; }
    }
}