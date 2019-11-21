//------------------------------------------------------------------
// <copyright file="WorkflowMemberModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//------------------------------------------------------------------
namespace Vasont.Inspire.Models.Workflow
{
    using System.Xml.Serialization;

    /// <summary>
    /// This class represents a user within a workflow
    /// </summary>
    [XmlType("Member")]
    public class WorkflowMemberModel
    {
        /// <summary>
        /// Gets or sets the identity of the user.
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets the email address of the member.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the full name of the user.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the type of the member, either a User or a Role.
        /// </summary>
        public string Type { get; set; }
    }
}