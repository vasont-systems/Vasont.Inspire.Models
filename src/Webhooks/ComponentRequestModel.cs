//---------------------------------------------------------------------------
// <copyright file="ComponentRequestModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Vasont.Inspire.Models.Webhooks
{
    using System;

    /// <summary>
    /// This class contains the model used for a component request.
    /// </summary>
    public class ComponentRequestModel
    {
        /// <summary>
        /// Gets or sets the identity of the request.
        /// </summary>
        public Guid RequestId { get; set; }

        /// <summary>
        /// Gets or sets the full name of the requester.
        /// </summary>
        public string RequesterName { get; set; }

        /// <summary>
        /// Gets or sets the e-mail of the requester.
        /// </summary>
        public string RequesterEmail { get; set; }
    }
}
