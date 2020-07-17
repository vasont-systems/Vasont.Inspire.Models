//-----------------------------------------------------------------------
// <copyright file="ComponentMetricsModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents metrics for a component within the system and is to be used for interaction with application user interfaces.
    /// </summary>
    public class ComponentMetricsModel
    {
        /// <summary>
        /// Gets or sets the XML Component Word Count.
        /// </summary>
        public int WordCount { get; set; }

        /// <summary>
        /// Gets or sets the XML Component Character Count.
        /// </summary>
        public int CharCount { get; set; }

        /// <summary>
        /// Gets or sets the XML Component Character Count Without Spaces.
        /// </summary>
        public int CharCountNoSpace { get; set; }

        /// <summary>
        /// Gets or sets the Component Size.
        /// </summary>
        public long FileSize { get; set; }
    }
}
