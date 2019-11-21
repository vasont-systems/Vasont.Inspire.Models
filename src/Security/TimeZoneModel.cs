//-----------------------------------------------------------------------
// <copyright file="TimeZoneModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Security
{
    /// <summary>
    /// This class represents a time zone record within the application database.
    /// </summary>
    public class TimeZoneModel : MinimalTimeZoneModel
    {
        /// <summary>
        /// Gets or sets the time zone long display name.
        /// </summary>
        public string LongName { get; set; }

        /// <summary>
        /// Gets or sets the time zone numerical offset.
        /// </summary>
        public double Offset { get; set; }
    }
}