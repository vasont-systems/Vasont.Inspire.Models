//-----------------------------------------------------------------------
// <copyright file="ExternalSystemModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components.Sync
{
    /// <summary>
    /// This class represents an external system that has interaction with the Inspire application.
    /// </summary>
    public class ExternalSystemModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the external system.
        /// </summary>
        public long ExternalSystemId { get; set; }

        /// <summary>
        /// Gets or sets the external system name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the external system description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether sync is active for this external system.
        /// </summary>
        public bool SyncActive { get; set; }
    }
}
