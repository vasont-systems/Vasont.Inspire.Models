//--------------------------------------------------------------------------
// <copyright file="ComponentExternalAssetsQueryModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;
    using Common;

    /// <summary>
    /// This class contains parameters passed to the query for retrieving component external assets.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
    public class ComponentExternalAssetsQueryModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets a list of component identities.
        /// </summary>
        public List<long> ComponentIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets search text that will be used to filter results.
        /// </summary>
        public string SearchText { get; set; }
    }
}