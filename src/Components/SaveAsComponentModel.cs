//--------------------------------------------------------------------------------
// <copyright file="SaveAsComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------------

namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class contains properties and information to request the system to create a component from a template.
    /// </summary>
    public class SaveAsComponentModel
    {
        /// <summary>
        /// Gets or sets the new component name that's used to create the new component.
        /// </summary>
        public string NewComponentName { get; set; }

        /// <summary>
        /// Gets or sets the identity of the existing template component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the folder of the new component.
        /// </summary>
        public long TargetFolderId { get; set; }

        /// <summary>
        /// Gets or sets the file name of the new component.
        /// </summary>
        public string TargetFileName { get; set; }

        /// <summary>
        /// Gets or sets the XML content of of the new component.
        /// </summary>
        public string TargetXml { get; set; }

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
        /// Gets or sets a value indicating whether the component create process will repair internal links.
        /// </summary>
        public bool RepairLinks { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the component create process is for a translation job component.
        /// </summary>
        public bool IsTranslation { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether the component create process is for a branch.
        /// </summary>
        public bool IsBranch { get; set; } = false;
    }
}