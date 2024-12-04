//-----------------------------------------------------------------------
// <copyright file="ExportProfileAttributeFilterModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class represents a profile attribute and the associated values used for filtering content during an export.
    /// </summary>
    [Obsolete("Use local DTOs", true)]
    public class ExportProfileAttributeFilterModel
    {
        /// <summary>
        /// Gets or sets the attribute name to find within the content.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a list of one or more values to filter.
        /// </summary>
        public List<string> Values { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the display attribute name to find within the content.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a list of one or more display values to filter.
        /// </summary>
        public List<string> DisplayValues { get; set; } = new List<string>();
    }
}