//-----------------------------------------------------------------------
// <copyright file="XmlLinkTypeModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Configuration
{
    /// <summary>
    /// This class represents an XML link type model within the system and is to be used for resolving component relationships.
    /// </summary>
    public class XmlLinkTypeModel
    {
        /// <summary>
        /// Gets or sets the Id of the xml link type.
        /// </summary>
        public long XmlLinkTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the xml link type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the link method.
        /// </summary>
        public LinkMethodModel LinkMethod { get; set; }

        /// <summary>
        /// Gets or sets the source attribute.
        /// </summary>
        public AttributeModel SourceAttribute { get; set; }

        /// <summary>
        /// Gets or sets the target attribute.
        /// </summary>
        public AttributeModel TargetAttribute { get; set; }

        /// <summary>
        /// Gets or sets the schema standard type.
        /// </summary>
        public string SchemaStandard { get; set; }
    }
}