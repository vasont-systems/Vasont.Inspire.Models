//-----------------------------------------------------------------------
// <copyright file="RecentComponentModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This model class represents the minimal component detail for a recent components list.
    /// </summary>
    public class RecentComponentModel
    {
        /// <summary>
        /// Gets or sets the component identity.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the component name.
        /// </summary>
        public string Name { get; set; }
    }
}