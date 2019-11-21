//-------------------------------------------------------------
// <copyright file="ModulePropertyModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------

namespace Vasont.Inspire.Models.Security
{
    using System.Collections.Generic;
    
    /// <summary>
    /// This class represents a module property definition within the application.
    /// </summary>
    public class ModulePropertyModel
    {
        /// <summary>
        /// Gets or sets the module property unique identity.
        /// </summary>
        public long ModulePropertyId { get; set; }

        /// <summary>
        /// Gets or sets the associated module identity.
        /// </summary>
        public long ModuleId { get; set; }

        /// <summary>
        /// Gets or sets the unique property Name for the module.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an optional description for the module.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a list of roles assigned access to the property.
        /// </summary>
        public List<MinimalRoleModel> Roles { get; set; } = new List<MinimalRoleModel>();

        /// <summary>
        /// Gets or sets a list of users assigned access to the property.
        /// </summary>
        public List<MinimalUserModel> Users { get; set; } = new List<MinimalUserModel>();
    }
}
