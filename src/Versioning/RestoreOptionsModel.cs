﻿//-----------------------------------------------------------------------
// <copyright file="RestoreOptionsModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Versioning
{
    /// <summary>
    /// This class contains optional arguments for the restoration mechanisms within the application.
    /// </summary>
    public class RestoreOptionsModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the component or folder will be restored is a deleted item.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component or folder will be restored to a new target location.
        /// </summary>
        public bool RestoreAsNew { get; set; }

        /// <summary>
        /// Gets or sets the new target folder location identity.
        /// </summary>
        public long TargetFolderId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entire snapshot should be restored or only a component.
        /// </summary>
        public bool RestoreAllComponents { get; set; }
    }
}
