//-----------------------------------------------------------------------
// <copyright file="BatchComponentsRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains properties required for the batch component API.
    /// </summary>
    [Obsolete("Use Local DTOs", true)]
    public class BatchComponentsRequestModel
    {
        /// <summary>
        /// Gets or sets the list of component identifiers.
        /// </summary>
        public List<long> ComponentIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets the list of component file names.
        /// </summary>
        public List<string> FileNames { get; set; } = new List<string>();
    }
}