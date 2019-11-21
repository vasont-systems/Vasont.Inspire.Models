//-----------------------------------------------------------------------
// <copyright file="LoggingExtensions.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Logging
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlTypes;
    using System.IO;
    using System.Reflection;
    using System.Text;

    /// <summary>
    /// This class contains extension methods for Logging.
    /// </summary>
    public class LoggingExtensions
    {
        #region private CSV methods

        /// <summary>
        /// This method is used to take a list of values and create a stream.
        /// </summary>
        /// <param name="listData">
        /// Contains the enumerable list of data to be converted to CSV string.
        /// </param>
        /// <param name="propertyInfos">
        /// Contains the enumerable list of the data type property info to CSV string.
        /// </param>
        /// <returns>Returns the resulting stream.</returns>
        public Stream CreateCsv(IEnumerable<object> listData, IList<PropertyInfo> propertyInfos)
        {
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                sb.Append(propertyInfo.Name).Append(",");
            }

            sb.Remove(sb.Length - 1, 1).AppendLine();

            // Adds a value for each property
            foreach (var el in listData)
            {
                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    sb.Append(this.MakeValueCsvFriendly(propertyInfo.GetValue(el, null))).Append(",");
                }

                sb.Remove(sb.Length - 1, 1).AppendLine();
            }

            var byteArray = System.Text.Encoding.UTF8.GetBytes(sb.ToString());
            var stream = new MemoryStream(byteArray);
            return stream;
        }

        /// <summary>
        /// This method is used to get the CSV value of a field.
        /// </summary>
        /// <param name="value">Contains the value to be converted.</param>
        /// <returns>Returns the resulting CSV string.</returns>
        private string MakeValueCsvFriendly(object value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            if (value is Nullable && ((INullable)value).IsNull)
            {
                return string.Empty;
            }

            if (value is DateTime)
            {
                if (((DateTime)value).TimeOfDay.TotalSeconds == 0)
                {
                    return ((DateTime)value).ToString("yyyy-MM-dd");
                }

                return ((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss");
            }

            string output = value.ToString();

            if (output.Contains(",") || output.Contains("\""))
            {
                output = '"' + output.Replace("\"", "\"\"") + '"';
            }

            if (output.Contains("\r\n"))
            {
                output = output.Replace("\r\n", " ");
            }

            return output;
        }

        #endregion
    }
}