//-----------------------------------------------------------------------
// <copyright file="MapSyncRequestModel.cs" company="Talegen">
//     Copyright (c) 2017 Talegen. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.WebApp.Api.Controllers.Content.Models
{
    /// <summary>
    /// This class represents a model of the map sync request
    /// </summary>
    public class MapSyncRequestModel
    {
        /// <summary>
        /// Gets or sets the node identity for the sync
        /// </summary>
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets the target component to return lock information.
        /// </summary>
        public long TargetComponentId { get; set; }
    }
}
