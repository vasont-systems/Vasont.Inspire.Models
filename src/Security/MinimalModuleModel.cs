//-------------------------------------------------------------
// <copyright file="MinimalModuleModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------

namespace Vasont.Inspire.Models.Security
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents a minimal Module representation for use within the application.
    /// </summary>
    public class MinimalModuleModel
    {
        /// <summary>
        /// Gets or sets the module title name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an optional module description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the module is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a list of module permission associations models.
        /// </summary>
        public List<ModulePermissionModel> Permissions { get; set; } = new List<ModulePermissionModel>();
    }
}
