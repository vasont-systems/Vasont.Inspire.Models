//-----------------------------------------------------------------------
// <copyright file="ComponentSnapshotExtendedProperties.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// This class contains component specific properties for a changeset snapshot model.
    /// </summary>
    public sealed class ComponentSnapshotExtendedProperties
    {
        /// <summary>
        /// Gets or sets the component language code.
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the component type information.
        /// </summary>
        public MinimalComponentTypeModel ComponentType { get; set; } = new MinimalComponentTypeModel();

        /// <summary>
        /// Gets or sets the component file name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the component state information.
        /// </summary>
        public ComponentStateType State { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component content changed during this snapshot and therefore has new content for this particular history record.
        /// </summary>
        public bool ContentChanged { get; set; }
    }
}
