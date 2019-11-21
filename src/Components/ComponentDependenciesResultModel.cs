//-----------------------------------------------------------------------------
// <copyright file="ComponentDependenciesResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a component dependencies query request.
    /// </summary>
    public class ComponentDependenciesResultModel
    {
        /// <summary>
        /// Gets or sets the total number of component dependencies.
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the resulting component dependencies from the query request.
        /// </summary>
        public List<ComponentDependencyModel> ComponentDependencies { get; set; }
    }
}
