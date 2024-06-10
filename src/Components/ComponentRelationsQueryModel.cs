//--------------------------------------------------------------------------
// <copyright file="ComponentRelationsQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;
    using Common;

    /// <summary>
    /// This class contains parameters passed to the query for retrieving component relations.
    /// </summary>
    [Obsolete("Use local DTO", true)]
    public class ComponentRelationsQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets a list of component identities.
        /// </summary>
        public List<long> ComponentIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets a list of target attribute values.
        /// </summary>
        public List<string> TargetAttributeValues { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets search text that will be used to filter results.
        /// </summary>
        public string SearchText { get; set; }
    }
}