//---------------------------------------------------------------------------
// <copyright file="ChangeComponentRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Webhooks
{
    /// <summary>
    /// This class contains the model used for a component change request.
    /// </summary>
    public class ChangeComponentRequestModel : ComponentRequestModel
    {
        /// <summary>
        /// Gets or sets the value that will be used to identify the component.
        /// </summary>
        public string ComponentIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the comment related to the change request.
        /// </summary>
        public string Comment { get; set; }
    }
}
