//-------------------------------------------------------------
// <copyright file="ComponentFrameworkModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using Microsoft.AspNetCore.Http;
    using Vasont.Inspire.Models.Common;

    /// <summary>
    /// This class represents a component framework.
    /// </summary>
    public class ComponentFrameworkModel : MicroCreatedUpdaterModelBase
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentFrameworkModel" /> class.
        /// </summary>
        public ComponentFrameworkModel()
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

        #endregion
    }
}
