//-------------------------------------------------------------
// <copyright file="ElectronicSignatureModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Utilities
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// Contains an enumerated list of resource types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResourceType
    {
        /// <summary>
        /// The resource that's esigned is of type component.
        /// </summary>
        Component,

        /// <summary>
        /// The resource that's esigned is of type review.
        /// </summary>
        Review,

        /// <summary>
        /// The resource that's esigned is of type translation.
        /// </summary>
        Translation
    }

    /// <summary>
    /// This class represents an electronic signature record within the application.
    /// </summary>
    public class ElectronicSignatureModel
    {
        /// <summary>
        /// Gets or sets the electronic signature identifier.
        /// </summary>
        public long ElectronicSignatureId { get; set; }

        /// <summary>
        /// Gets or sets the resource type.
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the name of the user who esigned.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the date when esigned.
        /// </summary>
        public DateTime SignedDate { get; set; }

        /// <summary>
        /// Gets or sets the reason for esignature.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the authentication token that's used as a proof of esignature.
        /// </summary>
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Gets or sets the record created date time.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the record creator model object.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; }
    }
}
