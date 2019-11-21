//-----------------------------------------------------------------------
// <copyright file="UnlockResultModel.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vasont.Inspire.Models.Components
{
    /// <summary>
    /// This class contains values used within the Unlocking Component Service.
    /// </summary>
    public class UnlockResultModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the unlocking component.
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// Gets or sets the name of the unlocking component.
        /// </summary>
        public string ComponentName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the unlock was complete.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the unlock unsuccessful due to permission or system lock.
        /// </summary>
        public bool PermissionUnlockError { get; set; }

        /// <summary>
        /// Gets or sets the failed message.
        /// </summary>
        public string FailedMessage { get; set; }

        /// <summary>
        /// Gets or sets the pending component edit.
        /// </summary>
        public MinimalEditorXmlModel PendingXmlEdit { get; set; }
    }
}
