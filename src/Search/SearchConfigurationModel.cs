//-----------------------------------------------------------------------
// <copyright file="SearchConfigurationModel.cs" company="Vasont Systems">
// Copyright (c) Vasont Systems. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Search
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;

    /// <summary>
    /// This class represents a search configuration model.
    /// </summary>
    public class SearchConfigurationModel
    {
        #region Public Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchConfigurationModel"/> class.
        /// </summary>
        public SearchConfigurationModel()
        {
            this.Operators = new List<KeyValuePair<SearchExpressionOperator, string>>();
            this.ValidValues = new List<KeyValuePair<string, string>>();
            this.DataType = SearchConfigurationDataType.String;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchConfigurationModel"/> class.
        /// </summary>
        /// <param name="fieldId">Contains the field identity used for filtering.</param>
        /// <param name="displayName">Contains the user interface field display name.</param>
        /// <param name="type">Contains the data type of the field.</param>
        /// <param name="validValues">Contains an optional list of valid values for the field.</param>
        /// <param name="compareExists">Contains a value indicating whether this is an existence comparison (not null).</param>
        /// <param name="overrideOperators">Contains an optional list of valid operators for the field.</param>
        public SearchConfigurationModel(string fieldId, string displayName, SearchConfigurationDataType type = SearchConfigurationDataType.String, List<KeyValuePair<string, string>> validValues = null, bool compareExists = false, Dictionary<SearchExpressionOperator, string> overrideOperators = null)
        {
            this.FieldId = fieldId;
            this.DisplayName = displayName;
            this.DataType = type;
            this.CompareExists = compareExists;
            this.Operators = overrideOperators?.Select(d => new KeyValuePair<SearchExpressionOperator, string>(d.Key, d.Value)).ToList() ?? SearchConfigurationDefaults.TypeOperators(type);
            this.ValidValues = validValues ?? new List<KeyValuePair<string, string>>();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the field identity.
        /// </summary>
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or sets the user interface display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is an existence comparison (not null)
        /// </summary>
        [JsonIgnore]
        public bool CompareExists { get; set; }

        /// <summary>
        /// Gets or sets the data type.
        /// </summary>
        public SearchConfigurationDataType DataType { get; set; }

        /// <summary>
        /// Gets or sets a list of operator key value pairs.
        /// </summary>
        public List<KeyValuePair<SearchExpressionOperator, string>> Operators { get; set; }

        /// <summary>
        /// Gets or sets a list of valid value key value pairs.
        /// </summary>
        public List<KeyValuePair<string, string>> ValidValues { get; set; }
        #endregion
    }
}
