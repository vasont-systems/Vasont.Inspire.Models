//-----------------------------------------------------------------------
// <copyright file="SubmissionAttributeModel.cs" company="GlobalLink Vasont">
//     Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Translations
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the optional submission attributes to send with a translation submission.
    /// </summary>
    public class SubmissionAttributeModel
    {
        /// <summary>Gets or sets the owner.</summary>
        public string Owner { get; set; }

        /// <summary>Gets or sets the submitter.</summary>
        public string Submitter { get; set; }

        /// <summary>Gets or sets the pm notes.</summary>
        public string PmNotes { get; set; }

        /// <summary>Gets or sets a value indicating whether this instance is urgent.</summary>
        public bool IsUrgent { get; set; }

        /// <summary>Gets or sets a comma separated list of the owners.</summary>
        public string Owners { get; set; }

        /// <summary>Gets or sets the meta data.</summary>
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>Gets or sets the custom attributes.</summary>
        public Dictionary<string, string> CustomAttributes { get; set; }
    }
}
