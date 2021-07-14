//-------------------------------------------------------------
// <copyright file="ComponentFramework.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using Microsoft.AspNetCore.Http;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a component framework.
    /// </summary>
    public class ComponentFramework
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentFramework" /> class.
        /// </summary>
        public ComponentFramework()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.UpdatedDate = DateTime.UtcNow;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the identity of the component framework.
        /// </summary>
        public long ComponentFrameworkId { get; set; }

        /// <summary>
        /// Gets or sets the name of the component framework.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the component framework.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a form file object.
        /// </summary>
        public IFormFile File { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the component framework is active.
        /// </summary>
        public bool Active { get; set; }

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

        #endregion
    }
}
