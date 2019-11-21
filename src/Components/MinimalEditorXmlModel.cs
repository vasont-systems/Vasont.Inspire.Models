//-----------------------------------------------------------------------
// <copyright file="MinimalEditorXmlModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Components
{
    using System;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a editor XML component model with minimal information that will used for interaction with application user interfaces.
    /// </summary>
    public class MinimalEditorXmlModel
    {
        /// <summary>
        /// Gets or sets the component identity value.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the component editor's identity value.
        /// </summary>
        public MinimalUserModel User { get; set; }

        /// <summary>
        /// Gets or sets the date time when the editor component was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the date time when the editor component was last updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the component's session identity .
        /// </summary>
        public string SessionId { get; set; }
    }
}
