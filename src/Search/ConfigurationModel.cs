//-------------------------------------------------------------
// <copyright file="ConfigurationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Search
{
    using System.Collections.Generic;
    
    /// <summary>
    /// This class contains a definition for the ad-hoc query component configuration
    /// </summary>
    public class ConfigurationModel
    {
        /// <summary>
        /// Gets or sets a list of valid field logic operators
        /// </summary>
        public List<KeyValuePair<SearchLogicOperator, string>> FieldOperators { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="SearchConfigurationModel"/> objects.
        /// </summary>
        public List<SearchConfigurationModel> SearchFields { get; set; }
    }
}