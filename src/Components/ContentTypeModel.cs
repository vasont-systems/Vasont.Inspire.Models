//-------------------------------------------------------------
// <copyright file="ContentTypeModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents a model related to a content type.
    /// </summary>
    public class ContentTypeModel
    {
        /// <summary>
        /// Gets or sets the identity of the content type.
        /// </summary>
        public long ContentTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the content type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the key value of the content type.
        /// </summary>
        public string ContentTypeKey { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is the default content type.
        /// </summary>
        public bool Default { get; set; }
    }
}