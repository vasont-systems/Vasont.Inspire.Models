//-----------------------------------------------------------------------
// <copyright file="ExportProfileAttributeFilterModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Transfers
{
    using System.Collections.Generic;
    
    /// <summary>
    /// This class represents a profile attribute and the associated values used for filtering content during an export.
    /// </summary>
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
    }
}
