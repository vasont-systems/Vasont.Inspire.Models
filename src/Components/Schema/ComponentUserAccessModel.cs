﻿//-----------------------------------------------------------------------
// <copyright file="ComponentUserAccessModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Components
{
    using System;

    /// <summary>
    /// This class represents a component access record for a specific user within the application.
    /// </summary>public class ComponentUserAccessModel
    public class ComponentUserAccessModel
    {
        /// <summary>
        /// Gets or sets the associated component identity value.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the user identity of the user accessing the component.
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets the date time when the component was last accessed.
        /// </summary>
        public DateTime LastAccessedDate { get; set; }

        /// <summary>
        /// Gets or sets the related component name.
        /// </summary>
        public string ComponentName { get; set; }

        /// <summary>
        /// Gets or sets the related user name.
        /// </summary>
        public string UserName { get; set; }
    }
}
