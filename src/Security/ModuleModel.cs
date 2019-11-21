//-------------------------------------------------------------
// <copyright file="ModuleModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------

namespace Vasont.Inspire.Models.Security
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Common;

    /// <summary>
    /// This class represents a Module representation for use within the application.
    /// </summary>
    public class ModuleModel : CreatedUpdaterModelBase
    {
        /// <summary>
        /// Gets or sets the module identity value.
        /// </summary>
        public long ModuleId { get; set; }

        /// <summary>
        /// Gets or sets the module package identity
        /// </summary>
        public long PackageId { get; set; }

        /// <summary>
        /// Gets or sets the related package name.
        /// </summary>
        public string PackageName { get; set; }

        /// <summary>
        /// Gets or sets the unique module key string.
        /// </summary>
        public string ModuleKey { get; set; }

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

        /// <summary>
        /// Gets or sets a list of module properties.
        /// </summary>
        public List<ModulePropertyModel> Properties { get; set; } = new List<ModulePropertyModel>();
    }
}
