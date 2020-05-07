//-----------------------------------------------------------------------
// <copyright file="DisplayValuePair.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    /// <summary>
    /// This class represents a base for displaying a name value pair combination.
    /// </summary>
    /// <typeparam name="N">Contains the display data type.</typeparam>
    /// <typeparam name="V">Contains the value data type.</typeparam>
    public abstract class DisplayValuePair<N, V>
    {
        /// <summary>
        /// Gets or sets the pair display value.
        /// </summary>
        public N Display { get; set; }

        /// <summary>
        /// Gets or sets the pair value.
        /// </summary>
        public V Value { get; set; }
    }
}