//-------------------------------------------------------------
// <copyright file="TranslationJobRelationModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using Vasont.Inspire.Models.Translations;

    /// <summary>
    /// This class model represents a component reference found within the data repository to be used for translation jobs.
    /// </summary>
    public class TranslationJobRelationModel : TranslationRelationModel
    {
        /// <summary>
        /// Gets or sets the relation translation job.
        /// </summary>
        public TranslationJobComponentModel TranslationJobComponent { get; set; }
    }
}