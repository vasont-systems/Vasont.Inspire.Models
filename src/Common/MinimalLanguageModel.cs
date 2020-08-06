//-----------------------------------------------------------------------
// <copyright file="MinimalLanguageModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    /// <summary>
    /// This class represents a minimal representation of a language within the application.
    /// </summary>
    public class MinimalLanguageModel
    {
        /// <summary>
        /// Gets or sets the unique language code.
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the language display name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the language is a UI locale.
        /// </summary>
        public bool IsLocale { get; set; }
    }
}