//---------------------------------------------------------------------
// <copyright file="DetailedComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a detailed component model with information that will used for interaction with application user interfaces.
    /// </summary>
    public class DetailedComponentModel : MinimalComponentModel
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedComponentModel" /> class.
        /// </summary>
        public DetailedComponentModel()
            : this(PermissionFlags.None)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedComponentModel" /> class.
        /// </summary>
        /// <param name="permissions">Contains an optional permissions value for the detailed component model.</param>
        public DetailedComponentModel(PermissionFlags permissions)
            : base(permissions)
        {
            this.Tags = new List<TagModel>();
            this.Properties = new List<ComponentPropertyModel>();
            this.Dependencies = new List<ComponentDependencyModel>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the language name and code appended together associated with the component.
        /// </summary>
        public string LanguageNameCode { get; set; }

        /// <summary>
        /// Gets or sets a list of tags associated with the component.
        /// </summary>
        public List<TagModel> Tags { get; set; }

        /// <summary>
        /// Gets or sets a comma delimited list of tag identities.
        /// </summary>
        public string TagIds { get; set; }

        /// <summary>
        /// Gets or sets a list of properties associated with the component.
        /// </summary>
        public List<ComponentPropertyModel> Properties { get; set; }

        /// <summary>
        /// Gets or sets a list of dependencies associated with the component.
        /// </summary>
        public List<ComponentDependencyModel> Dependencies { get; set; }

        #endregion
    }
}