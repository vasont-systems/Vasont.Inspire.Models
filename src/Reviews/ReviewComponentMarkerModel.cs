//--------------------------------------------------------------------
// <copyright file="ReviewComponentMarkerModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//--------------------------------------------------------------------
namespace Vasont.Inspire.Models.Reviews
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of review component change types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReviewComponentMarkerActionType
    {
        /// <summary>
        /// Contains a value that indicates the change was accepted.
        /// </summary>
        Accept,

        /// <summary>
        /// Contains a value that indicates the change was rejected.
        /// </summary>
        Reject
    }

    /// <summary>
    /// This class represents a review component marker used for review audit trails.
    /// </summary>
    public class ReviewComponentMarkerModel
    {
        /// <summary>
        /// Gets or sets the marker identity.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the marker action type.
        /// </summary>
        public ReviewComponentMarkerActionType ActionType { get; set; }

        /// <summary>
        /// Gets or sets the marker action reason.
        /// </summary>
        public string ActionReason { get; set; }

        /// <summary>
        /// Gets or sets the marker action user name.
        /// </summary>
        public string ActionUserName { get; set; }

        /// <summary>
        /// Gets or sets the marker text.
        /// </summary>
        public string Text { get; set; }
    }
}
