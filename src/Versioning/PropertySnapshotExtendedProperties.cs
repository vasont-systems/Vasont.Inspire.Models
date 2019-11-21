//-----------------------------------------------------------------------
// <copyright file="PropertySnapshotExtendedProperties.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    /// <summary>
    /// This class contains folder specific properties for a changeset snapshot model.
    /// </summary>
    public sealed class PropertySnapshotExtendedProperties
    {
        /// <summary>
        /// Gets or sets the unique identity of the property.
        /// </summary>
        public long PropertyId { get; set; }

        /// <summary>
        /// Gets or sets the name of the property
        /// </summary>
        public string Name { get; set; }
    }
}
