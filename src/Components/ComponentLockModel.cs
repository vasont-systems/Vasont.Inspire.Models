//-------------------------------------------------------------
// <copyright file="ComponentLockModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Core.Properties;
    using Vasont.Inspire.Models.Security;

    /// <summary>
    /// Contains an enumerated list of component lock types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentLockType
    {
        /// <summary>
        /// The component lock is standard and is locked by a user for editing.
        /// </summary>
        Standard,

        /// <summary>
        /// The component lock is review and is locked because it is part of a review.
        /// </summary>
        Review,

        /// <summary>
        /// The component lock is translation and is locked because it is part of a translation.
        /// </summary>
        Translation
    }

    /// <summary>
    /// This class represents a component lock for a component within the application.
    /// </summary>
    public class ComponentLockModel
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentLockModel"/> class.
        /// </summary>
        public ComponentLockModel()
        {
            this.LockedBy = new MicroUserModel();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the component identifier.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the component lock type.
        /// </summary>
        public ComponentLockType Type { get; set; }

        /// <summary>
        /// Gets or sets the locked date information.
        /// </summary>
        public DateTime LockedDate { get; set; }

        /// <summary>
        /// Gets or sets the locked by user model information.
        /// </summary>
        public MicroUserModel LockedBy { get; set; }

        /// <summary>
        /// Gets the lock reason.
        /// </summary>
        public string LockReason
        {
            get
            {
                string lockReason;

                switch (this.Type)
                {
                    case ComponentLockType.Review:
                        lockReason = Resources.LockedForReviewByText;
                        break;

                    case ComponentLockType.Translation:
                        lockReason = Resources.LockedForTranslationByText;
                        break;

                    default:
                        lockReason = Resources.LockedByText;
                        break;
                }

                return $"{lockReason}: {this.LockedBy.FullName}";
            }
        }

        /// <summary>
        /// Gets or sets a value indicating a system lock
        /// </summary>
        public bool SystemLock => this.Type != ComponentLockType.Standard;

        #endregion
    }
}