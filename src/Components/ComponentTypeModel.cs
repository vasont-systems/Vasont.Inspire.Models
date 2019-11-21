//-----------------------------------------------------------------------
// <copyright file="ComponentTypeModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class is a model representation of a component type definition within the application.
    /// </summary>
    public class ComponentTypeModel : MinimalComponentTypeModel
    {
        #region Public Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentTypeModel"/> class.
        /// </summary>
        public ComponentTypeModel()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.UpdatedDate = DateTime.UtcNow;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the XML DTD public identity value.
        /// </summary>
        public string DocumentTypePublicId { get; set; }

        /// <summary>
        /// Gets or sets the XML DTD system identity value.
        /// </summary>
        public string DocumentTypeSystemId { get; set; }

        /// <summary>
        /// Gets or sets the root element name utilized to identify the XML-based component type if no document type is defined.
        /// </summary>
        public string RootElementName { get; set; }

        /// <summary>
        /// Gets or sets the date time when the record was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model of the creating user.
        /// </summary>
        public MicroUserModel CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date time when the record was last updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model of the updating user.
        /// </summary>
        public MicroUserModel UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component type is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component type is a default.
        /// </summary>
        public bool Default { get; set; }
        #endregion
    }
}