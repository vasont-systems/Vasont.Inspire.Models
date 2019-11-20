//---------------------------------------------------------------------
// <copyright file="MicroComponentModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//---------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Vasont.Inspire.Core.Storage;
    using Vasont.Inspire.Models.Projects;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a component model with absolute minimum information for application interfaces.
    /// </summary>
    public class MicroComponentModel
    {
        #region Private Fields
        /// <summary>
        /// Contains the item type for the specified minimal component.
        /// </summary>
        private ProjectFolderItemType itemType;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="MicroComponentModel"/> class.
        /// </summary>
        public MicroComponentModel()
        {
            this.itemType = ProjectFolderItemType.Component;
            this.Permissions = new PermissionModel(PermissionFlags.None);
        }

        /// <summary>
        /// Gets or sets the unique identity of the component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets a minimal component type model.
        /// </summary>
        public MinimalComponentTypeModel ComponentType { get; set; }

        /// <summary>
        /// Gets or sets a permission model.
        /// </summary>
        public PermissionModel Permissions { get; set; }

        /// <summary>
        /// Gets or sets the component name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the component file name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets a value indicating whether the component is an image.
        /// </summary>
        public bool IsImage => this.ComponentType != null && this.ComponentType.Binary && Files.IsImageFile(this.FileName);

        /// <summary>
        /// Gets or sets the project item type
        /// </summary>
        public ProjectFolderItemType Type
        {
            get
            {
                // if binary...
                if (this.itemType == ProjectFolderItemType.Component && this.ComponentType != null && this.ComponentType.Binary)
                {
                    // use image if component is known image
                    this.itemType = this.IsImage ? ProjectFolderItemType.Image : ProjectFolderItemType.Binary;
                }

                return this.itemType;
            }

            set => this.itemType = value != ProjectFolderItemType.Folder ? value : ProjectFolderItemType.Component;
        }
    }       
}