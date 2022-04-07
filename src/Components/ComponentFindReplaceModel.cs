//-------------------------------------------------------------
// <copyright file="ComponentFindReplaceModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class a component find and replace request.
    /// </summary>
    public class ComponentFindReplaceModel
    {
        /// <summary>
        /// Gets or sets the find value.
        /// </summary>
        public string FindValue { get; set; }

        /// <summary>
        /// Gets or sets the replace value.
        /// </summary>
        public string ReplaceValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the request is for a reponly only.
        /// </summary>
        public bool ReportOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the request is for a case sensitive search.
        /// </summary>
        public bool CaseSensitive { get; set; }

        /// <summary>
        /// Gets or sets a list of components to process.
        /// </summary>
        public List<long> ComponentIds { get; set; }
    }
}