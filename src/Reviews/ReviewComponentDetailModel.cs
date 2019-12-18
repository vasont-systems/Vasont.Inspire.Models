//--------------------------------------------------------------------------
// <copyright file="ReviewComponentDetailModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;
    using Vasont.Inspire.Models.Components;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class represents a review component detail within the application.
    /// </summary>
    public class ReviewComponentDetailModel
    {
        /// <summary>
        /// Gets or sets the identity of the review component.
        /// </summary>
        public long ReviewComponentId { get; set; }

        /// <summary>
        /// Gets or sets the identity of the review.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the component.
        /// </summary>
        public MinimalComponentModel Component { get; set; } = new MinimalComponentModel();

        /// <summary>
        /// Gets or sets the changeset of the component history record.
        /// </summary>
        public Guid ChangesetId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this component is for context purposes only.
        /// </summary>
        public bool ContextOnly { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the review component was created.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the user information about the user who created the review component.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; } = new MinimalUserModel();

        /// <summary>
        /// Gets or sets the review component comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets a sort order value for displaying the review component.
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Gets or sets the reviewer component if the current user is a reviewer for this review.
        /// </summary>
        public ReviewerComponentModel ReviewerComponent { get; set; } = new ReviewerComponentModel();
    }
}
