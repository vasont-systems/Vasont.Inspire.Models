//-----------------------------------------------------------------------
// <copyright file="MinimalTimeZoneModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Security
{
    using System;

    /// <summary>
    /// This class represents a minimal set of time zone model information.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
    public class MinimalTimeZoneModel
    {
        /// <summary>
        /// Gets or sets the time zone identity value.
        /// </summary>
        public int TimeZoneId { get; set; }

        /// <summary>
        /// Gets or sets the time zone short name.
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the time zone is the default selection.
        /// </summary>
        public bool Default { get; set; }

        /// <summary>
        /// Gets or sets the IANA name for the time zone.
        /// </summary>
        public string IanaName { get; set; }
    }
}