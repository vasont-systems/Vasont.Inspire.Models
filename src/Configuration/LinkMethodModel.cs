//-----------------------------------------------------------------------
// <copyright file="LinkMethodModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Configuration
{
    using System;

    /// <summary>
    /// This class represents a link method within the system and is to be used for resolving component relationships.
    /// </summary>
    [Obsolete("Use local DTOs", false)]
    public class LinkMethodModel
    {
        /// <summary>
        /// Gets or sets the identity of the link method.
        /// </summary>
        public long LinkMethodId { get; set; }

        /// <summary>
        /// Gets or sets the name of the link method.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the link method.
        /// </summary>
        public string Description { get; set; }
    }
}