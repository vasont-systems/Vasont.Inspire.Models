//-----------------------------------------------------------------------
// <copyright file="AreaNotifications.cs" company="GlobalLink Vasont">
// Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.AreaNotifications
{
    using System.Collections.Generic;
    using Vasont.Inspire.Models.Notifications;

    /// <summary>
    /// This class represents a group of clasess for each notification setting area.
    /// </summary>
    public class AreaNotifications
    {
        /// <summary>
        /// This class represents a group of notification setting for components area.
        /// </summary>
        public class ComponentNotificationPreference
        {
            /// <summary>
            /// Gets or sets a value indicating whether a Notifications should be sent.
            /// </summary>
            public bool CanNotify { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether AutorepairDone notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> AutorepairDone { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether NewBranchFromRootMap notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> NewBranchFromRootMap { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether CompareMapsResults notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> CompareMapsResults { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether RelationshipRebuildDone notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> RelationshipRebuildDone { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether FollowedComponentModified notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> FollowedComponentModified { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether FindReplaceDone notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> FindReplaceDone { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether BatchTaggingDone notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> BatchTaggingDone { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether RenameComponentDone notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> RenameComponentDone { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether ComponentCompletenessReportReady notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> ComponentCompletenessReportReady { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether FolderChanges notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> FolderChanges { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether ComponentSnapshotsReady notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> ComponentSnapshotsReady { get; set; }
        }

        /// <summary>
        /// This class represents a group of notification setting for project area.
        /// </summary>
        public class ProjectNotificationPreference
        {
            /// <summary>
            /// Gets or sets a value indicating whether a Notifications should be sent.
            /// </summary>
            public bool CanNotify { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether AssignmentCreated notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> AssignmentCreated { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether AssignmentUpdated notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> AssignmentUpdated { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether AssignmentDeleted notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> AssignmentDeleted { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether Overdue notifications configuration.
            /// </summary>
            public Overdue Overdue { get; set; } = new Overdue();
        }

        /// <summary>
        /// This class represents a group of notification setting for taxonomy area.
        /// </summary>
        public class TaxonomyNotificationPreference
        {
            /// <summary>
            /// Gets or sets a value indicating whether a Notifications should be sent.
            /// </summary>
            public bool CanNotify { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether SkosCreated notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> SkosCreated { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether SkosReportReady notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> SkosReportReady { get; set; }
        }

        /// <summary>
        /// This class represents a group of notification setting for reviewa area.
        /// </summary>
        public class ReviewsNotificationPreference
        {
            /// <summary>
            /// Gets or sets a value indicating whether a notification should be sent.
            /// </summary>
            public bool CanNotify { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether ReviewCreated notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> ReviewCreated { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether ReviewUpdated notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> ReviewUpdated { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether ReviewCompleted notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> ReviewCompleted { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether ReviewCancelled notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> ReviewCancelled { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether NewReviewDiscussion notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> NewReviewDiscussion { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether ReviewComponentUpdated notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> ReviewComponentUpdated { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether NewReviewerAssigned notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> NewReviewerAssigned { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether ReviewerAssignmentCancelled notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> ReviewerAssignmentCancelled { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether ReviewReportReady notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> ReviewReportReady { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether Overdue notifications configuration.
            /// </summary>
            public Overdue Overdue { get; set; } = new Overdue();
        }

        /// <summary>
        /// This class represents a group of notification setting for translation area.
        /// </summary>
        public class TranslationsNotificationPreference
        {
            /// <summary>
            /// Gets or sets a value indicating whether a Notifications should be sent.
            /// </summary>
            public bool CanNotify { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether TranslationCreated notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> TranslationCreated { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether TranslationCreationFailed notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> TranslationCreationFailed { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether TranslationSubmissionFailed notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> TranslationSubmissionFailed { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether TranslationSubmissionReset notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> TranslationSubmissionReset { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether TranslationSubmissionResetFailed notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> TranslationSubmissionResetFailed { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether TranslationCancelled notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> TranslationCancelled { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether TranslationReopened notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> TranslationReopened { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether TranslationCompleted notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> TranslationCompleted { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether Overdue notifications configuration.
            /// </summary>
            public Overdue Overdue { get; set; } = new Overdue();
        }

        /// <summary>
        /// This class represents a group of notification setting for publishing area.
        /// </summary>
        public class PublishingNotificationPreference
        {
            /// <summary>
            /// Gets or sets a value indicating whether a notification should be sent.
            /// </summary>
            public bool CanNotify { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether PublishRequestSubmitted notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> PublishRequestSubmitted { get; set; }
        }

        /// <summary>
        /// This class represents a group of notification setting for import area.
        /// </summary>
        public class ImportNotificationPreference
        {
            /// <summary>
            /// Gets or sets a value indicating whether a Notification should be sent.
            /// </summary>
            public bool CanNotify { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether ImportResults notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> ImportResults { get; set; }
        }

        /// <summary>
        /// This class represents a group of notification setting for export area.
        /// </summary>
        public class ExportNotificationPreference
        {
            /// <summary>
            /// Gets or sets a value indicating whether a Notification should be sent.
            /// </summary>
            public bool CanNotify { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether ExportResults notifications channels.
            /// </summary>
            public List<NotificationPreferenceChannel> ExportResults { get; set; }
        }

        /// <summary>
        /// This class represents a group of notification setting for everything else area.
        /// </summary>
        public class EverythingElseNotificationPreference
        {
            /// <summary>
            /// Gets or sets a value indicating whether a Notification should be sent.
            /// </summary>
            public bool CanNotify { get; set; }
        }
    }
}
