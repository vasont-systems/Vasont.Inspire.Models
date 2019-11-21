//-----------------------------------------------------------------------------------
// <copyright file="ComponentRelationsRepairResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System.Collections.Generic;

    /// <summary>
    /// This class represents the results of a component relation repair request.
    /// </summary>
    public class ComponentRelationsRepairResultModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the repair was successful.
        /// </summary>
        public bool IsRepairSuccessful { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the element check box should be initially checked in the repair dialog that is displayed after an unsuccessful auto repair.
        /// </summary>
        public bool ElementBoxChecked { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether an element is required to be selected before allowing the target to be chosen.
        /// </summary>
        public bool ElementRequired { get; set; }

        /// <summary>
        /// Gets or sets the element names that are allowed to be picked in the repair dialog that is displayed upon an unsuccessful auto repair.
        /// </summary>
        public List<string> AllowedElements { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the resulting components that matched the current relationship.
        /// </summary>
        public List<MinimalComponentModel> Components { get; set; } = new List<MinimalComponentModel>();
    }
}
