//-----------------------------------------------------------------------
// <copyright file="FeatureModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    /// <summary>
    /// This class represents a feature for the application.
    /// </summary>
    public class FeatureModel
    {
        /// <summary>
        /// Gets or sets the identity of the feature.
        /// </summary>
        public long FeatureId { get; set; }

        /// <summary>
        /// Gets or sets the name of the feature.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the feature is enabled.
        /// </summary>
        public bool Enabled { get; set; }
    }
}