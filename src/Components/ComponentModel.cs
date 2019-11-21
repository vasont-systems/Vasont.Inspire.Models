//-----------------------------------------------------------------------
// <copyright file="ComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a component within the system and is to be used for interaction with application user interfaces.
    /// </summary>
    public class ComponentModel : MinimalComponentModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentModel"/> class.
        /// </summary>
        public ComponentModel()
        {
            this.RolePermissions = new List<MinimalPermissionModel>();
            this.UserPermissions = new List<MinimalPermissionModel>();
            this.Folders = new List<MinimalFolderModel>();
            this.Properties = new List<ComponentPropertyModel>();
            this.Tags = new List<TagModel>();
        }

        /// <summary>
        /// Gets or sets the component type.
        /// </summary>
        public new ComponentTypeModel ComponentType { get; set; }

        /// <summary>
        /// Gets or sets the component type display name.
        /// </summary>
        public string ComponentTypeName { get; set; }

        /// <summary>
        /// Gets or sets the identity of the content type for binary content.
        /// </summary>
        public long ContentTypeId { get; set; }

        /// <summary>
        /// Gets or sets the binary content of the component.
        /// </summary>
        public byte[] BinaryContent { get; set; }

        /// <summary>
        /// Gets or sets the XML content of the component.
        /// </summary>
        public string XmlContent { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="ComponentRolePermissionModel"/> objects containing component role permission assignments.
        /// </summary>
        public List<MinimalPermissionModel> RolePermissions { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="ComponentUserPermissionModel"/> objects containing component user permission assignments.
        /// </summary>
        public List<MinimalPermissionModel> UserPermissions { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="FolderModel"/> objects containing linked component folders.
        /// </summary>
        public List<MinimalFolderModel> Folders { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="ComponentPropertyModel"/> objects containing component property assignments.
        /// </summary>
        public List<ComponentPropertyModel> Properties { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="TagModel"/> objects containing component tag assignments.
        /// </summary>
        public List<TagModel> Tags { get; set; }

        /// <summary>
        /// Gets or sets the record creator model object.
        /// </summary>
        public new MicroUserModel CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the record updater model object.
        /// </summary>
        public new MicroUserModel UpdatedBy { get; set; }
    }
}
