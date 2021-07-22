//-----------------------------------------------------------------------
// <copyright file="ValidationSchemaModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Configuration
{
    public class ValidationSchemaModel
    {
        /// <summary>
        /// Gets or sets the validation schema identity.
        /// </summary>
        public long SchemaId { get; set; }

        /// <summary>
        /// Gets or sets the validation schema unique identity.
        /// </summary>
        public long UniqueId { get; set; }

        /// <summary>
        /// Gets or sets the name valid value.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description valid value.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the schema standard.
        /// </summary>
        /// <value>
        /// The name of the schema standard.
        /// </value>
        public string SchemaStandard { get; set; }

        /// <summary>
        ///  Gets or sets the component type identifier.
        /// </summary>
        /// <value>The component type identifier.</value>
        public long ComponentTypeId { get; set; }

        /// <summary>
        /// Gets or sets the content of the validation schema.
        /// </summary>
        /// <value>The content.</value>
        public byte[] SchemaDataFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ValidationSchema" /> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}