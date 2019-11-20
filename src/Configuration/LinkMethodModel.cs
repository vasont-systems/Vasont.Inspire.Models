//-----------------------------------------------------------------------
// <copyright file="LinkMethodModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Configuration
{
    /// <summary>
    /// This class represents a link method within the system and is to be used for resolving component relationships.
    /// </summary>
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