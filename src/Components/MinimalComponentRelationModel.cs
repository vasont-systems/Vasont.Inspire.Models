//-------------------------------------------------------------
// <copyright file="MinimalComponentRelationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>namespace Vasont.Inspire.Api.Core.Components.Models
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    ///  This class model represents a minimal component reference found within the data repository
    /// </summary>
    public class MinimalComponentRelationModel
    {
        /// <summary>
        ///  Gets or sets the component relation source component identity.
        /// </summary>
        public long? SourceComponentId { get; set; }

        /// <summary>
        ///  Gets or sets the component relation target component identity.
        /// </summary>
        public long? TargetComponentId { get; set; }

        /// <summary>
        ///  Gets or sets the component relation source element name.
        /// </summary>
        public string SourceElementName { get; set; }

        /// <summary>
        ///  Gets or sets the component relation source attribute value.
        /// </summary>
        public string SourceAttributeValue { get; set; }

        /// <summary>
        ///  Gets or sets the component relation target element name.
        /// </summary>
        public string TargetElementName { get; set; }

        /// <summary>
        ///  Gets or sets the component relation target attribute value.
        /// </summary>
        public string TargetAttributeValue { get; set; }
    }
}

