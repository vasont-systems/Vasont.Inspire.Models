//-----------------------------------------------------------------------------------
// <copyright file="ElementResultsModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents the element results of an advanced content search.
    /// </summary>
    public class ElementResultsModel
    {
        /// <summary>
        /// Gets or sets a value indicating the component identity.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component name.
        /// </summary>
        public string ComponentName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the element text.
        /// </summary>
        public string ElementText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the element XML snippet.
        /// </summary>
        public string XmlSnippet { get; set; }
    }
}
