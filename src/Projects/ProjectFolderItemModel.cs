//-----------------------------------------------------------------------
// <copyright file="ProjectFolderItemModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Projects
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Security;
    using Vasont.Inspire.Core.Extensions;
    using Vasont.Inspire.Core.Storage;
    using Vasont.Inspire.Models.Components;

    /// <summary>
    /// Contains an enumerated list of project folder item types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProjectFolderItemType
    {
        /// <summary>
        /// The folder item is a folder.
        /// </summary>
        Folder,

        /// <summary>
        /// The folder item is a component.
        /// </summary>
        Component,

        /// <summary>
        /// The folder item is a binary image component.
        /// </summary>
        Image,

        /// <summary>
        /// The folder item is a binary component.
        /// </summary>
        Binary
    }

    /// <summary>
    /// This class represents a project folder within the application.
    /// </summary>
    public class ProjectFolderItemModel
    {
        #region Private Fields
        /// <summary>
        /// Contains the unique identity value for this model.
        /// </summary>
        private string uniqueId;

        /// <summary>
        /// Contains the project folder item type for the specified component.
        /// </summary>
        private ProjectFolderItemType itemType;

        /// <summary>
        /// Contains the unique component identity value.
        /// </summary>
        private long componentId;

        /// <summary>
        /// Contains the unique folder identity value.
        /// </summary>
        private long folderId;

        /// <summary>
        /// Contains the unique parent folder identity value.
        /// </summary>
        private long? parentFolderId;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectFolderItemModel"/> class.
        /// </summary>
        public ProjectFolderItemModel()
        {
            this.Children = new List<ProjectFolderItemModel>();
            this.Type = ProjectFolderItemType.Folder;
            this.CreatedDate = DateTime.UtcNow;
        }
        
        #region Common Folder Item Properties

        /// <summary>
        /// Gets or sets the unique identifier of the project folder item.
        /// </summary>
        [JsonProperty(Order = 1)]
        public string Id
        {
            get => !string.IsNullOrWhiteSpace(this.uniqueId) ? this.uniqueId : this.uniqueId = this.GenerateUniqueId();

            set => this.uniqueId = value;
        }

        /// <summary>
        /// Gets a value indicating whether the folder item is an image component.
        /// </summary>
        public bool IsImage => this.itemType == ProjectFolderItemType.Component && this.ComponentType != null && this.ComponentType.Binary && Files.IsImageFile(this.FileName);

        /// <summary>
        /// Gets or sets the project item type
        /// </summary>
        [JsonProperty(Order = 2)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ProjectFolderItemType Type
        {
            get
            {
                if (this.itemType == ProjectFolderItemType.Component && this.ComponentType != null && this.ComponentType.Binary)
                {
                    this.itemType = this.IsImage ? ProjectFolderItemType.Image : ProjectFolderItemType.Binary;
                }

                return this.itemType;
            }

            set => this.itemType = value;
        }

        /// <summary>
        /// Gets or sets the folder item type via a text string.
        /// </summary>
        [JsonIgnore]
        public string TypeText
        {
            get => this.Type.ToString();
            set => this.Type = value.ToEnum<ProjectFolderItemType>();
        }

        /// <summary>
        /// Gets or sets the parent project folder item identity value.
        /// </summary>
        [JsonProperty(Order = 3)]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or sets the associated project identity value.
        /// </summary>
        [JsonProperty(Order = 4)]
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the project folder name.
        /// </summary>
        [JsonProperty(Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the component identity value.
        /// </summary>
        public long ComponentId
        {
            get => this.componentId;

            set
            {
                this.componentId = value;
                this.Id = "Component_" + value;
            }
        }

        /// <summary>
        /// Gets or sets the folder identity value.
        /// </summary>
        public long FolderId
        {
            get => this.folderId;

            set
            {
                this.folderId = value;
                this.Id = "Folder_" + value;
            }
        }

        /// <summary>
        /// Gets or sets the related parent folder identity value.
        /// </summary>
        public long? ParentFolderId
        {
            get => this.parentFolderId;

            set
            {
                this.parentFolderId = value;
                this.ParentId = value.HasValue ? "Folder_" + value : string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the date time when the project folder item was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the date time when the project folder item was last updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the updater user information model.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="ProjectFolderItemModel"/> objects representing sub-folders and/or components within this project folder item.
        /// </summary>
        public List<ProjectFolderItemModel> Children { get; set; }
        #endregion

        #region Project Component Item Properties
        /// <summary>
        /// Gets or sets the component type.
        /// </summary>
        public MinimalComponentTypeModel ComponentType { get; set; }

        /// <summary>
        /// Gets or sets the language code of component content.
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the file name of the component.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the component state information.
        /// </summary>
        public ComponentStateType State { get; set; }

        /// <summary>
        /// Gets or sets the state via a text value.
        /// </summary>
        [JsonIgnore]
        public string StateText
        {
            get => this.State.ToString();
            set => this.State = value.ToEnum<ComponentStateType>();
        }

        /// <summary>
        /// Gets or sets a value indicating the locked state of the component.
        /// </summary>
        public ComponentLockModel Lock { get; set; }

        /// <summary>
        /// Gets or sets the permissions information for the specified component.
        /// </summary>
        public PermissionModel Permissions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this component can translate.
        /// </summary>
        public bool CanTranslate { get; set; }
        #endregion

        #region Project Folder Properties 
        /// <summary>
        /// Gets or sets the project folder description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this project folder will be considered the default folder when adding new content.
        /// </summary>
        public bool DefaultFolder { get; set; }

        /// <summary>
        /// Gets or sets the folder ordering index override.
        /// </summary>
        public int OrderIndex { get; set; }
        #endregion

        #region Private Properties
        /// <summary>
        /// Gets or sets a value indicating whether this item is a folder.
        /// </summary>
        private bool IsFolder => this.Type == ProjectFolderItemType.Folder;

        /// <summary>
        /// Gets or sets a value indicating whether this item is a component.
        /// </summary>
        private bool IsComponent => this.Type != ProjectFolderItemType.Folder;
        #endregion

        #region Conditional Folder Serialization Methods
        /// <summary>
        /// This method is called by the serializer to determine if the property DefaultFolder should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldSerializeDefaultFolder()
        {
            return this.IsFolder;
        }

        /// <summary>
        /// This method is called by the serializer to determine if the property Description should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.IsFolder;
        }

        /// <summary>
        /// This method is called by the serializer to determine if the property Description should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldSerializeOrderIndex()
        {
            return this.IsFolder;
        }

        /// <summary>
        /// This method is called by the serializer to determine if the property FolderId should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldSerializeFolderId()
        {
            return this.IsFolder;
        }
        #endregion

        #region Conditional Component Serialization Methods
        /// <summary>
        /// This method is called by the serializer to determine if the property Permissions should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldPermissions()
        {
            return this.IsComponent;
        }

        /// <summary>
        /// This method is called by the serializer to determine if the property ComponentType should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldSerializeComponentType()
        {
            return this.IsComponent;
        }

        /// <summary>
        /// This method is called by the serializer to determine if the property LanguageCode should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldSerializeLanguageCode()
        {
            return this.IsComponent;
        }

        /// <summary>
        /// This method is called by the serializer to determine if the property FileName should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldSerializeFileName()
        {
            return this.IsComponent;
        }

        /// <summary>
        /// This method is called by the serializer to determine if the property Approved should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldSerializeApproved()
        {
            return this.IsComponent;
        }

        /// <summary>
        /// This method is called by the serializer to determine if the property Lock should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldSerializeLock()
        {
            return this.IsComponent;
        }

        /// <summary>
        /// This method is called by the serializer to determine if the property ComponentId should be rendered.
        /// </summary>
        /// <returns>Returns a value indicating whether to render the related property.</returns>
        public bool ShouldSerializeComponentId()
        {
            return this.IsComponent;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// This method is used to generate the unique identity for the model.
        /// </summary>
        /// <returns>Returns a unique identity string.</returns>
        private string GenerateUniqueId()
        {
            return this.Type == ProjectFolderItemType.Folder ? "Folder_" + this.folderId : $"Component_{this.componentId}"; ////_{Guid.NewGuid()}";
        }
        #endregion
    }
}