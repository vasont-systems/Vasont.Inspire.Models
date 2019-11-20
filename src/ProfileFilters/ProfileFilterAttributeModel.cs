//---------------------------------------------------------------------------
// <copyright file="ProfileFilterAttributeModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------

namespace Vasont.Inspire.Models.ProfileFilters
{
    /// <summary>
    /// This class defines the properties of a profile filter attribute model.
    /// </summary>
    public class ProfileFilterAttributeModel
    {
         /// <summary>
        /// Gets or sets the identity of the attribute.
        /// </summary>
        public long AttributeId { get; set; }

        /// <summary>
        /// Gets or sets the attribute name.
        /// </summary>
        public string AttributeName { get; set; }

        /// <summary>
        /// Gets or sets the attribute display name.
        /// </summary>
        public string AttributeNameDisplay { get; set; }

        /// <summary>
        /// Gets or sets the identity of the attribute value.
        /// </summary>
        public long AttributeValueId { get; set; }

        /// <summary>
        /// Gets or sets the attribute value.
        /// </summary>
        public string AttributeValue { get; set; }
        
        /// <summary>
        /// Gets or sets the attribute display value.
        /// </summary>
        public string AttributeValueDisplay { get; set; }
    }
}