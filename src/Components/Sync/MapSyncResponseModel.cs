//-----------------------------------------------------------------------
// <copyright file="MapSyncResponseModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Components.Sync
{
    /// <summary>
    /// This class represents a response for the map sync request
    /// </summary>
    public class MapSyncResponseModel
    {
        /// <summary>
        /// Gets or sets the node identity
        /// </summary>
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets the lock information related to the target component.
        /// </summary>
        public ComponentLockModel Lock { get; set; }
    }
}
