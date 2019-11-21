//---------------------------------------------------------------
// <copyright file="MapComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a map definition for the application.
    /// </summary>
    public class MapComponentModel : MinimalComponentModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapComponentModel"/> class.
        /// </summary>
        public MapComponentModel()
            : this(PermissionFlags.None)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapComponentModel"/> class.
        /// </summary>
        /// <param name="permissions">Contains an optional permissions value for the minimal component model.</param>
        public MapComponentModel(PermissionFlags permissions)
            : base(permissions)
        {
            this.RootElement = new MapNodeModel();
            this.PrecedingNodes = new List<MapNodeModel>();
        }

        /// <summary>
        /// Gets or sets a value indicating whether the map can only be read and not edited.
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the save shall submit the contents back into the database.
        /// If this is set to false, the save operation will update temporary storage.
        /// </summary>
        public bool Submit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the map had been modified.
        /// </summary>
        public bool Modified { get; set; }

        /// <summary>
        /// Gets or sets a date value of the last update.
        /// </summary>
        public DateTime LastUpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets a list of nodes that occur before the root element.
        /// </summary>
        public List<MapNodeModel> PrecedingNodes { get; set; }

        /// <summary>
        /// Gets or sets the root element of the map.
        /// </summary>
        public MapNodeModel RootElement { get; set; }

        /// <summary>
        /// Gets or sets a list of nodes that occur after the root element.
        /// </summary>
        public List<MapNodeModel> FollowingNodes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component can be used with the content editor.
        /// </summary>
        public bool CanUseContentEditor { get; set; }
    }
}
