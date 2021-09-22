//-------------------------------------------------------------
// <copyright file="SearchType.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Search
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Gets or sets an enumerated list of available search types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SearchType
    {
        /// <summary>
        /// Advanced search of components
        /// </summary>
        Component,

        /// <summary>
        /// Advanced search of component histories
        /// </summary>
        ComponentHistory,

        /// <summary>
        /// Advanced search of translations
        /// </summary>
        Translation,

        /// <summary>
        /// Advanced search of reviews
        /// </summary>
        Review,

        /// <summary>
        /// Advanced search of reviewers
        /// </summary>
        Reviewer,

        /// <summary>
        /// Advanced search of projects
        /// </summary>
        Project,

        /// <summary>
        /// Advanced search of project assignments
        /// </summary>
        Assignment,

        /// <summary>
        /// Advanced search of workflow
        /// </summary>
        Workflow
    }
}