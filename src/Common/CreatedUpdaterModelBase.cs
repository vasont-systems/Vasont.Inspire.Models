//-------------------------------------------------------------
// <copyright file="CreatedUpdaterModelBase.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Common
{
    using System;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// This class contains basic created and updater properties for model records.
    /// </summary>
    public abstract class CreatedUpdaterModelBase
    {
        /// <summary>
        /// Gets or sets the record created date time.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the record creator model object.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the record last updated date time.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the record updater model object.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; }
    }
}