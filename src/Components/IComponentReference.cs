//-------------------------------------------------------------
// <copyright file="IComponentReference.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;

    /// <summary>
    /// This interface defines a minimum implementation of a component reference model within the application.
    /// </summary>
    public interface IComponentReference
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the file name
        /// </summary>
        string TargetName { get; set; }

        /// <summary>
        /// Gets or sets the root identity
        /// </summary>
        string TargetRootId { get; set; }

        /// <summary>
        /// Gets or sets the element identity
        /// </summary>
        string TargetElementId { get; set; }

        /// <summary>
        /// Gets or sets a Uri object for the reference.
        /// </summary>
        Uri Address { get; set; }
        #endregion

        #region Public Override Methods
        /// <summary>
        /// This method is used to convert the object to a content reference pointer string.
        /// </summary>
        /// <returns>Returns the object properties as a formatted string for the definition.</returns>
        string ToString();
        #endregion
    }
}