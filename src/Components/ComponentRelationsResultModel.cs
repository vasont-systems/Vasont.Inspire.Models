//-----------------------------------------------------------------------------
// <copyright file="ComponentRelationsResultModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------

namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a component relations query request.
    /// </summary>
    public class ComponentRelationsResultModel
    {
        /// <summary>
        /// Gets or sets the total number of component relations.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting component relations from the query request.
        /// </summary>
        public List<ComponentReferenceModel> ComponentRelations { get; set; }
    }
}
