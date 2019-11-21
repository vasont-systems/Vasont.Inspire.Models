//-------------------------------------------------------------------------
// <copyright file="MinimalProfileFilterModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------
namespace Vasont.Inspire.Models.ProfileFilters
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class defines the properties of a minimal profile filter model.
    /// </summary>
    public class MinimalProfileFilterModel
    {        
        /// <summary>
        /// Gets or sets the identity of the profile filter.
        /// </summary>
        public long ProfileFilterId { get; set; }

        /// <summary>
        /// Gets or sets the owner of the profile filter.
        /// </summary>
        public MicroUserModel Owner { get; set; }

        /// <summary>
        /// Gets or sets the title of the profile filter.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the profile filter.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a list attribute values that are included in the profile filter.
        /// </summary>
        public List<ProfileFilterAttributeModel> AttributeValues { get; set; } = new List<ProfileFilterAttributeModel>();

        /// <summary>
        /// Gets or sets a value indicating whether the filter is available to all system users.
        /// </summary>
        public bool SystemShared { get; set; }

        /// <summary>
        /// Gets or sets the group name for display.
        /// </summary>
        public string GroupName { get; set; }
    }
}