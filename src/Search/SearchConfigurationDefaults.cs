//-------------------------------------------------------------
// <copyright file="SearchConfigurationDefaults.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------

namespace Vasont.Inspire.Models.Search
{
    using System.Collections.Generic;
    using System.Linq;
    using Vasont.Inspire.Core.Extensions;
    using Vasont.Inspire.Core.Properties;

    /// <summary>
    /// This class contains statically defined search configurations for operator lists.
    /// </summary>
    public static class SearchConfigurationDefaults
    {
        /// <summary>
        /// Gets a list of operators used for the string data type.
        /// </summary>
        public static Dictionary<SearchExpressionOperator, string> StringOperators => new Dictionary<SearchExpressionOperator, string>
        {
            { SearchExpressionOperator.Equals, SearchExpressionOperator.Equals.ToDescription() },
            { SearchExpressionOperator.NotEquals, SearchExpressionOperator.NotEquals.ToDescription() },
            { SearchExpressionOperator.Contains, SearchExpressionOperator.Contains.ToDescription() },
            { SearchExpressionOperator.DoesNotContain, SearchExpressionOperator.DoesNotContain.ToDescription() },
            { SearchExpressionOperator.StartsWith, SearchExpressionOperator.StartsWith.ToDescription() },
            { SearchExpressionOperator.DoesNotStartWith, SearchExpressionOperator.DoesNotStartWith.ToDescription() },
            { SearchExpressionOperator.EndsWith, SearchExpressionOperator.EndsWith.ToDescription() },
            { SearchExpressionOperator.DoesNotEndWith, SearchExpressionOperator.DoesNotEndWith.ToDescription() }
        };

        /// <summary>
        /// Gets a list of operators used for the short integer data type.
        /// </summary>
        public static Dictionary<SearchExpressionOperator, string> LongOperators => new Dictionary<SearchExpressionOperator, string>
        {
            // place these in the order you expect UI to display them, first entry will be the default operator
            { SearchExpressionOperator.Equals, SearchExpressionOperator.Equals.ToDescription() },
            { SearchExpressionOperator.NotEquals, SearchExpressionOperator.NotEquals.ToDescription() },
            { SearchExpressionOperator.GreaterThan, SearchExpressionOperator.GreaterThan.ToDescription() },
            { SearchExpressionOperator.GreaterThanOrEqual, SearchExpressionOperator.GreaterThanOrEqual.ToDescription() },
            { SearchExpressionOperator.LessThan, SearchExpressionOperator.LessThan.ToDescription() },
            { SearchExpressionOperator.LessThanOrEqual, SearchExpressionOperator.LessThanOrEqual.ToDescription() }
        };

        /// <summary>
        /// Gets a list of operators used for the simplified short integer data type.
        /// </summary>
        public static Dictionary<SearchExpressionOperator, string> SimplifiedLongOperators => new Dictionary<SearchExpressionOperator, string>
        {
            // place these in the order you expect UI to display them, first entry will be the default operator
            { SearchExpressionOperator.Equals, SearchExpressionOperator.Equals.ToDescription() },
            { SearchExpressionOperator.NotEquals, SearchExpressionOperator.NotEquals.ToDescription() }
        };

        /// <summary>
        /// Gets a list of operators used for the integer data type.
        /// </summary>
        public static Dictionary<SearchExpressionOperator, string> IntegerOperators => new Dictionary<SearchExpressionOperator, string>
        {
            // place these in the order you expect UI to display them, first entry will be the default operator
            { SearchExpressionOperator.Equals, SearchExpressionOperator.Equals.ToDescription() },
            { SearchExpressionOperator.NotEquals, SearchExpressionOperator.NotEquals.ToDescription() },
            { SearchExpressionOperator.GreaterThan, SearchExpressionOperator.GreaterThan.ToDescription() },
            { SearchExpressionOperator.GreaterThanOrEqual, SearchExpressionOperator.GreaterThanOrEqual.ToDescription() },
            { SearchExpressionOperator.LessThan, SearchExpressionOperator.LessThan.ToDescription() },
            { SearchExpressionOperator.LessThanOrEqual, SearchExpressionOperator.LessThanOrEqual.ToDescription() }
        };

        /// <summary>
        /// Gets a list of operators used for the simplified integer data type.
        /// </summary>
        public static Dictionary<SearchExpressionOperator, string> SimplifiedIntegerOperators => new Dictionary<SearchExpressionOperator, string>
        {
            // place these in the order you expect UI to display them, first entry will be the default operator
            { SearchExpressionOperator.Equals, SearchExpressionOperator.Equals.ToDescription() },
            { SearchExpressionOperator.NotEquals, SearchExpressionOperator.NotEquals.ToDescription() }
        };

        /// <summary>
        /// Gets a list of operators used for the boolean data type.
        /// </summary>
        public static Dictionary<SearchExpressionOperator, string> BooleanOperators => new Dictionary<SearchExpressionOperator, string>
        {
            // place these in the order you expect UI to display them, first entry will be the default operator
            { SearchExpressionOperator.Equals, SearchExpressionOperator.Equals.ToDescription() },
            { SearchExpressionOperator.NotEquals, SearchExpressionOperator.NotEquals.ToDescription() }
        };

        /// <summary>
        /// Gets a list of operators used for the date time data type.
        /// </summary>
        public static Dictionary<SearchExpressionOperator, string> DateTimeOperators => new Dictionary<SearchExpressionOperator, string>
        {
            // place these in the order you expect UI to display them, first entry will be the default operator
            { SearchExpressionOperator.Equals, SearchExpressionOperator.Equals.ToDescription() },
            { SearchExpressionOperator.NotEquals, SearchExpressionOperator.NotEquals.ToDescription() },
            { SearchExpressionOperator.GreaterThan, SearchExpressionOperator.GreaterThan.ToDescription() },
            { SearchExpressionOperator.GreaterThanOrEqual, SearchExpressionOperator.GreaterThanOrEqual.ToDescription() },
            { SearchExpressionOperator.LessThan, SearchExpressionOperator.LessThan.ToDescription() },
            { SearchExpressionOperator.LessThanOrEqual, SearchExpressionOperator.LessThanOrEqual.ToDescription() }
        };

        /// <summary>
        /// Gets a list of operators used for models that utilize valid values.
        /// </summary>
        public static Dictionary<SearchExpressionOperator, string> ValidValueOperators => new Dictionary<SearchExpressionOperator, string>
        {
            // place these in the order you expect UI to display them, first entry will be the default operator
            { SearchExpressionOperator.Equals, SearchExpressionOperator.Equals.ToDescription() },
            { SearchExpressionOperator.NotEquals, SearchExpressionOperator.NotEquals.ToDescription() },
            { SearchExpressionOperator.GreaterThan, SearchExpressionOperator.GreaterThan.ToDescription() },
            { SearchExpressionOperator.GreaterThanOrEqual, SearchExpressionOperator.GreaterThanOrEqual.ToDescription() },
            { SearchExpressionOperator.LessThan, SearchExpressionOperator.LessThan.ToDescription() },
            { SearchExpressionOperator.LessThanOrEqual, SearchExpressionOperator.LessThanOrEqual.ToDescription() }
        };

        /// <summary>
        /// Gets a list of operators used for content searches
        /// </summary>
        public static Dictionary<SearchExpressionOperator, string> ContentOperators => new Dictionary<SearchExpressionOperator, string>
        {
            { SearchExpressionOperator.Contains, SearchExpressionOperator.Contains.ToDescription() },
            { SearchExpressionOperator.DoesNotContain, SearchExpressionOperator.DoesNotContain.ToDescription() }
        };

        /// <summary>
        /// Gets a list of operators used for the boolean data type.
        /// </summary>
        public static List<KeyValuePair<string, string>> BooleanValidValues => new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("true", Resources.LabelYesText),
            new KeyValuePair<string, string>("false", Resources.LabelNoText)
        };

        /// <summary>
        /// This method is used to build a list of search expression operators based on the specified type.
        /// </summary>
        /// <param name="type">Contains the type to build expression operators for.</param>
        /// <returns>Returns a list of expression operators.</returns>
        public static List<KeyValuePair<SearchExpressionOperator, string>> TypeOperators(SearchConfigurationDataType type)
        {
            Dictionary<SearchExpressionOperator, string> result;

            switch (type)
            {
                case SearchConfigurationDataType.Long:
                    result = LongOperators;
                    break;

                case SearchConfigurationDataType.SimplifiedLong:
                    result = SimplifiedLongOperators;
                    break;

                case SearchConfigurationDataType.Int:
                    result = IntegerOperators;
                    break;

                case SearchConfigurationDataType.SimplifiedInt:
                    result = SimplifiedIntegerOperators;
                    break;

                case SearchConfigurationDataType.DateTime:
                    result = DateTimeOperators;
                    break;

                case SearchConfigurationDataType.Boolean:
                    result = BooleanOperators;
                    break;

                default:
                    result = StringOperators;
                    break;
            }

            return result.Select(d => new KeyValuePair<SearchExpressionOperator, string>(d.Key, d.Value)).ToList();
        }
    }
}