//-----------------------------------------------------------------------
// <copyright file="NotificationSettingsPreferenceModel.cs" company="GlobalLink Vasont">
//     Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Inspire.Models.Notifications
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Vasont.Inspire.Models.AreaNotifications;

    /// <summary>
    /// This enumeration is used for the notification preferences channels.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationPreferenceChannel
    {
        /// <summary>
        /// Email channel
        /// </summary>
        Email,

        /// <summary>
        /// Slack channel
        /// </summary>
        Slack,

        /// <summary>
        /// Inapp Channel
        /// </summary>
        Inapp
    }

    /// <summary>
    /// This enumeration is used for the frequency.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationOverdueFrequency
    {
        /// <summary>
        /// None frequency
        /// </summary>
        None,

        /// <summary>
        /// Daily frequency
        /// </summary>
        Daily,

        /// <summary>
        /// 2 days frequency
        /// </summary>
        Days2,

        /// <summary>
        /// 3 days frequency
        /// </summary>
        Days3,

        /// <summary>
        /// Weekly frequency
        /// </summary>
        Weekly
    }

    /// <summary>
    /// This class represents a model of user notification settings preferences.
    /// </summary>
    public class NotificationSettingsPreferenceModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether a Notifications should be sent.
        /// </summary>
        public bool CanNotify { get; set; }

        /// <summary>
        /// Gets or sets a value indicating notifications channels.
        /// </summary>
        public List<NotificationPreferenceChannel> Channels { get; set; }

        /// <summary>
        /// Gets or sets a value indicating areas notifications preferences.
        /// </summary>
        public Area Areas { get; set; } = new Area();
    }

    /// <summary>
    /// This class represents the configuration areas.
    /// </summary>
    public class Area
    {
        /// <summary>
        /// Gets or sets a value indicating components area notifications preferences.
        /// </summary>
        public AreaNotifications.ComponentNotificationPreference Components { get; set; }

        /// <summary>
        /// Gets or sets a value indicating projects area notifications preferences.
        /// </summary>
        public AreaNotifications.ProjectNotificationPreference Projects { get; set; }

        /// <summary>
        /// Gets or sets a value indicating taxonomy area notifications preferences.
        /// </summary>
        public AreaNotifications.TaxonomyNotificationPreference Taxonomy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating reviews area notifications preferences.
        /// </summary>
        public AreaNotifications.ReviewsNotificationPreference Reviews { get; set; }

        /// <summary>
        /// Gets or sets a value indicating translations area notifications preferences.
        /// </summary>
        public AreaNotifications.TranslationsNotificationPreference Translations { get; set; }

        /// <summary>
        /// Gets or sets a value indicating publishing area notifications preferences.
        /// </summary>
        public AreaNotifications.PublishingNotificationPreference Publishing { get; set; }

        /// <summary>
        /// Gets or sets a value indicating import area notifications preferences.
        /// </summary>
        public AreaNotifications.ImportNotificationPreference Import { get; set; }

        /// <summary>
        /// Gets or sets a value indicating export area notifications preferences.
        /// </summary>
        public AreaNotifications.ExportNotificationPreference Export { get; set; }

        /// <summary>
        /// Gets or sets a value indicating everythingElse area notifications preferences.
        /// </summary>
        public AreaNotifications.EverythingElseNotificationPreference EverythingElse { get; set; }
    }

    /// <summary>
    /// This class represents Overdue configuration.
    /// </summary>
    public class Overdue
    {
        /// <summary>
        /// Gets or sets a value indicating daysBefore value.
        /// </summary>
        public int DaysBefore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating daysBeforeRepeat value.
        /// </summary>
        public NotificationOverdueFrequency DaysBeforeRepeat { get; set; }

        /// <summary>
        /// Gets or sets a value indicating pastDueRepeat value.
        /// </summary>
        public NotificationOverdueFrequency PastDueRepeat { get; set; }
    }
}
