//---------------------------------------------------------------------
// <copyright file="ComponentDependencyModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using Security;

    /// <summary>
    /// This class represents a component dependency model that defines a referencing component.
    /// </summary>
    public class ComponentDependencyModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentDependencyModel" /> class.
        /// </summary>
        public ComponentDependencyModel()
            : this(PermissionFlags.None)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentDependencyModel" /> class.
        /// </summary>
        /// <param name="permissions">Contains the permissions object.</param>
        public ComponentDependencyModel(PermissionFlags permissions)
        {
            this.Permissions = new PermissionModel(permissions);
        }

        /// <summary>
        /// Gets or sets the unique identity of the component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the component name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the component file name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the component type name.
        /// </summary>
        public string ComponentTypeName { get; set; }

        /// <summary>
        /// Gets or sets the component's folder path.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the unique identity of the component folder.
        /// </summary>
        public long FolderId { get; set; }

        /// <summary>
        /// Gets or sets the component state information.
        /// </summary>
        public ComponentStateType State { get; set; }

        /// <summary>
        /// Gets or sets the lock information related to the component.
        /// </summary>
        public ComponentLockModel Lock { get; set; }

        /// <summary>
        /// Gets or sets the permissions model for the component.
        /// </summary>
        public PermissionModel Permissions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component is editable.
        /// </summary>
        public bool IsEditable { get; set; }
    }
}