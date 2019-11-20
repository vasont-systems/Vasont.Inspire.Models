//-----------------------------------------------------------------------
// <copyright file="TagModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents a component tag within the application.
    /// </summary>
    public class TagModel
    {
        /// <summary>
        /// Gets or sets the unique tag identity value.
        /// </summary>
        public long TagId { get; set; }

        /// <summary>
        /// Gets or sets the unique tag name.
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// Gets or sets the number of components that use the tag.
        /// </summary>
        public int ReferenceCount { get; set; }
    }
}