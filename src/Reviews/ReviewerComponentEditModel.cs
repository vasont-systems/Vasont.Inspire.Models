//--------------------------------------------------------------------------
// <copyright file="ReviewerComponentEditModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;
    using Vasont.Inspire.Models.Components;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a reviewer component edit within the application.
    /// </summary>
    public class ReviewerComponentEditModel
    {
        /// <summary>
        /// Gets or sets the identity of the reviewer component.
        /// </summary>
        public long ReviewerComponentId { get; set; }

        /// <summary>
        /// Gets or sets the component model.
        /// </summary>
        public MinimalComponentModel Component { get; set; }

        /// <summary>
        /// Gets or sets the identity of the review component.
        /// </summary>
        public long ReviewComponentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the reviewer component has been completed.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the review component is context only.
        /// </summary>
        public bool ContextOnly { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the review component was last saved.
        /// </summary>
        public DateTime? SavedDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the last reviewer update.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user that date and time of the last reviewer update.
        /// </summary>
        public MinimalUserModel UpdatedByUser { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the reviewer component comment.
        /// </summary>
        public string Comment { get; set; }
    }
}
