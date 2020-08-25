//-----------------------------------------------------------------------
// <copyright file="MapSyncResponseModel.cs" company="Talegen">
//     Copyright (c) 2017 Talegen. All rights reserved.
// </copyright>
// <author>Rob Kennedy</author>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents a response for the map sync request.
    /// </summary>
    public class MapSyncResponseModel
    {
        /// <summary>
        /// Gets or sets the node identity.
        /// </summary>
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets the lock information related to the target component.
        /// </summary>
        public ComponentLockModel Lock { get; set; }
    }
}
