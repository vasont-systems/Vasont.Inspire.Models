//--------------------------------------------------------------------
// <copyright file="ReviewComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Components;
    using Vasont.Inspire.Models.ReviewComponents;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// Contains an enumerated list of review component types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReviewComponentType
    {
        /// <summary>
        /// Contains a value that indicates the original review component content.
        /// </summary>
        Original,

        /// <summary>
        /// Contains a value that indicates the merged review component content.
        /// </summary>
        Merged,

        /// <summary>
        /// Contains a value that indicates the merged review component is being resolved.
        /// </summary>
        Resolving,

        /// <summary>
        /// Contains a value that indicates the final review component content.
        /// </summary>
        Final
    }

    /// <summary>
    /// Contains an enumerated list of review component change types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReviewComponentChangeType
    {
        /// <summary>
        /// Contains a value that indicates the change was an insert.
        /// </summary>
        Insert,

        /// <summary>
        /// Contains a value that indicates the change was a remove.
        /// </summary>
        Remove
    }

    /// <summary>
    /// This class represents a review component within the application.
    /// </summary>
    public class ReviewComponentModel
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
        /// Gets or sets the review component lock.
        /// </summary>
        public ReviewComponentLockModel ReviewComponentLock { get; set; } = new ReviewComponentLockModel();

        /// <summary>
        /// Gets or sets a sort order value for displaying the review component.
        /// </summary>
        public int SortOrder { get; set; }
    }
}
