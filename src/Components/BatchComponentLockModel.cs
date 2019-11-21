//-------------------------------------------------------------
// <copyright file="BatchComponentLockModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-------------------------------------------------------------
namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class represents a batched component lock for a component within the application.
    /// </summary>
    public class BatchComponentLockModel : ComponentLockModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchComponentLockModel"/> class.
        /// </summary>
        public BatchComponentLockModel()
        {
            this.LockSucceeded = true;
        }
        
        /// <summary>
        /// Gets or sets the name of the locking component.
        /// </summary>
        public string ComponentName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [lock succeeded].
        /// </summary>
        public bool LockSucceeded { get; set; }

        /// <summary>
        /// Gets or sets the failed message.
        /// </summary>
        public string FailedMessage { get; set; }
    }
}