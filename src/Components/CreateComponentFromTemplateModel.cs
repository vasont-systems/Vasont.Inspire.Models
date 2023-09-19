//--------------------------------------------------------------------------------
// <copyright file="CreateComponentFromTemplateModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class contains properties and information to request the system to create a component from a template.
    /// </summary>
    public class CreateComponentFromTemplateModel
    {
        /// <summary>
        /// Gets or sets the new component name that's used to create the new component.
        /// </summary>
        public string NewComponentName { get; set; }

        /// <summary>
        /// Gets or sets the identity of the existing template component.
        /// </summary>
        public long TemplateComponentId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the folder of the new component.
        /// </summary>
        public long TargetFolderId { get; set; }

        /// <summary>
        /// Gets or sets the language of the new component.
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the identity of the project to be added to.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the project folder to be added to.
        /// </summary>
        public long ProjectFolderId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the new component will be a template.
        /// </summary>
        public bool CreateAsTemplate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the new component will override the file name.
        /// </summary>
        public bool OverrideFileName { get; set; }

        /// <summary>
        /// Gets or sets the new component file name that's used to create the new component.
        /// </summary>
        public string NewComponentFileName { get; set; }
    }
}