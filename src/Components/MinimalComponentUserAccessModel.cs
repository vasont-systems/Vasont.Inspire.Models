//-----------------------------------------------------------------------
// <copyright file="MinimalComponentUserAccessModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a user access defined within a <see cref="ComponentModel"/> class. It is a stripped down version
    /// of the <see cref="ComponentUserAccessModel"/> and returns only essential information related to the user access of the component.
    /// </summary>
    public class MinimalComponentUserAccessModel
    {
        /// <summary>
        /// Gets or sets the user identity of the user accessing the component.
        /// </summary>
        public MinimalUserModel User { get; set; }

        /// <summary>
        /// Gets or sets the date time when the component was last accessed.
        /// </summary>
        public DateTime LastAccessedDate { get; set; }
    }
}
