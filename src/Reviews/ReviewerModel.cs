//-------------------------------------------------------------
// <copyright file="ReviewerModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// Contains an enumerated list of reviewer component state types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReviewerStateType
    {
        /// <summary>
        /// Contains a value that indicates the reviewer session is pending.
        /// </summary>
        Pending,

        /// <summary>
        /// Contains a value that indicates the reviewer is reviewing.
        /// </summary>
        Reviewing,

        /// <summary>
        /// Contains a value that indicates the reviewer has completed reviewing.
        /// </summary>
        Completed,

        /// <summary>
        /// Contains a value that indicates the reviewer assignment has been cancelled.
        /// </summary>
        Cancelled
    }

    /// <summary>
    /// This class represents a reviewer within the application.
    /// </summary>
    public class ReviewerModel
    {
        /// <summary>
        /// Gets or sets the identity of the review.
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the reviewer user.
        /// </summary>
        public MinimalUserModel User { get; set; }

        /// <summary>
        /// Gets or sets the state of the reviewer component.
        /// </summary>
        public ReviewerStateType State { get; set; } = ReviewerStateType.Reviewing;

        /// <summary>
        /// Gets or sets a value indicating whether the reviewer can make comments.
        /// </summary>
        public bool CanComment { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the reviewer can make track changes.
        /// </summary>
        public bool CanTrackChanges { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the reviewer will receive notifications related to this review.
        /// </summary>
        public bool ReceiveNotifications { get; set; } = true;

        /// <summary>
        /// Gets or sets the date and time when the reviewer component was completed.
        /// </summary>
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or sets the comment associated with the reviewer.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the review workflow submittal that is associated with this reviewer assignment. 
        /// </summary>
        public ReviewWorkflowSubmittalModel ReviewWorkflowSubmittal { get; set; }
    }
}
