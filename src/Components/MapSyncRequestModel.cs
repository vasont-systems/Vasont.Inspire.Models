//-----------------------------------------------------------------------
// <copyright file="NapSyncRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents a model of the map sync request.
    /// </summary>
    public class MapSyncRequestModel
    {
        /// <summary>
        /// Gets or sets the node identity for the sync.
        /// </summary>
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets the target component to return lock information.
        /// </summary>
        public long TargetComponentId { get; set; }
    }
}
